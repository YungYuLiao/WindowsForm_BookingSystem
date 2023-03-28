# 觀紫民宿訂房系統

**Keyword: windowsform、OOP、兩層式架構(客戶端的使用者介面層與伺服器端的資料服務層)**
1. 使用ADO.NET技術存取和操作資料庫
2. 將連線資料庫、執行SQL Server資料庫的通用操作及創建SqlParameter對象的集合寫成Utility.dll(分別為SqlDbHelper及SqlParameterBuilder)
3. 以ViewModel提供用戶界面所需的數據和邏輯，並在UserService連接資料庫

## 會員登入、註冊、修改會員資料、登出
1. 撰寫ValidationHelper類別，用於顯示輸入表單操作是否通過驗證，錯誤則會調用DisplayErrorByErrorProvider方法，在界面上顯示驗證錯誤
2. 驗證: 
* 登入欄位必填、帳號密碼是否正確
* 註冊欄位必填、電話格式是否正確
* 修改會員資料欄位必填、電話格式是否正確
3. 密碼皆以*隱藏，以保護隱私和提高安全性
4. 登入後方能看到主頁，將登入頁設置為主頁的Owner屬性達成此效果，並於主頁呈現登入者姓名
5. 登出後則跳出登入頁，同時刪除購物車內資料

## 主頁

## 訂房、購物車、結帳

## 訂單查詢、取消
