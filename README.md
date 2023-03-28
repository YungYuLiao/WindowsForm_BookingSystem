# 觀紫民宿訂房系統

**Keyword: windowsform、ADO.NET、OOP、兩層式架構(客戶端的使用者介面層與伺服器端的資料服務層)**
1. 使用ADO.NET技術存取和操作資料庫
2. 將連線資料庫、執行SQL Server資料庫的通用操作及創建SqlParameter對象的集合寫成Utility.dll(分別為SqlDbHelper及SqlParameterBuilder)
3. 以ViewModel提供用戶界面所需的數據和邏輯，並在UserService連接資料庫
4. 從資料庫中返回的資料為多筆時，以IEnumerable<T>泛型介面回傳，開發人員可以根據自己的需要選擇轉換成List<T>或Array等型別，可以減少記憶體佔用，並提高效能
5. 以private存取修飾詞用於儲存不可變更資訊，保護數據的封裝性，讓外部的使用者不能直接訪問這些數據　　

## 會員登入、註冊、修改會員資料、登出
1. 撰寫ValidationHelper類別，用於顯示輸入表單操作是否通過驗證，錯誤則會調用DisplayErrorByErrorProvider方法，在界面上顯示驗證錯誤
  
![register](https://user-images.githubusercontent.com/115922701/228169077-1a8c4c0e-3cb2-4d34-88cc-2d17dab0dd0f.PNG)
  
2. 驗證: 
* 登入欄位必填、帳號密碼是否正確
* 註冊欄位必填、電話格式是否正確、帳號是否已註冊過
* 修改會員資料欄位必填、電話格式是否正確
3. 密碼皆以*隱藏，以保護隱私和提高安全性
4. 登入後方能看到主頁，是將登入頁設置為主頁的Owner屬性達成此效果
5. 登出後則跳出登入視窗，同時刪除購物車內資料　　

## 主頁
  
![Recording 2023-03-28 at 16 24 29](https://user-images.githubusercontent.com/115922701/228177318-a4d533ff-8650-41d5-b33d-a1fc4820c628.gif)

1. 主頁為主視窗，為各子視窗設置MdiParent屬性
2. 撰寫ChangeImage方法，利用switch語法達成按左右按鍵時改變case，實作出變更照片及房型敘述的效果


## 訂房、購物車、結帳（一頁式）
  
![Recording 2023-03-28 at 16 20 47](https://user-images.githubusercontent.com/115922701/228174569-1ac01b95-ccaa-4e35-9225-06e5fbe1bcae.gif)

1. 按下立即訂房按鈕後，需閱讀入住須知，判斷是否按下確定後才會跳出訂房視窗
2. 入住時間及退房時間皆有驗證，如：入住日期不可早於今日、入住日期不可晚於或等於退房日期、訂房時間不可超過一星期
3. 搜尋房型後，於資料庫中搜尋，並顯示出選擇的時間區間內是否有空房，若有空房顯示出radio button供選取
4. 須點選房型的radio button，加床和選擇的按鍵才能點選，是以Control的Enable屬性變更實踐，以防止使用者在未選擇時點按
5. 選擇後加入購物車，並以dataGridView呈現購物車內容，點重新選擇則會刪除購物車內容，並再次搜尋可選擇的房型
6. 即時計算需付訂金及總金額，訂金有做四捨五入計算，並使用型別decimal，且以千分位數表示　　
7. 驗證:
* 匯款資料必填
* 匯款金額若與系統金額不同，則出現警示
* 匯款帳號僅須後五碼
8. 按下完成預定按鈕後，同時將取得的資料寫入三張資料表(訂單資訊、預定房型資訊及匯款資訊)  
-- 因預定房型資訊因和訂單資訊有設定關聯性，同時寫入時會有FK衝突，故以SQL 語法 `SELECT IDENT_CURRENT ('Order') as Current_Identity`返回自動增加的識別欄位的最後一個值,寫入房型資訊的資料表以解決此問題　　

## 訂單查詢、訂單詳情、取消訂單
  
  ![Recording 2023-03-28 at 16 16 00](https://user-images.githubusercontent.com/115922701/228173095-f9f6780d-cc7a-4c7f-b198-3e91964c3bd9.gif)
 
1. 訂單查詢視窗中的dataGridView點按後，把 OrderID傳給訂單詳情的建構函數，用以呈現該筆訂單的房型資訊
2. 訂單詳情同時繫結匯款資訊和訂房資訊做呈現
3. 取消訂單不直接刪除資料庫中資料，而是以狀態欄位紀錄是否取消，好處是當需要對訂單進行帳務對帳時，可避免因為刪除資料而導致帳務錯誤，也可以查詢已取消的訂單
  

