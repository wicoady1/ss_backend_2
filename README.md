# [ss_backend_2] Sale Stock Backend Assessment

## How to Run Locally
//GTKSharp + DB SQLite
- Mono + SQLite Prerequisites: Run Shell Script "mono_sqlite_install.sh"
- Compile Program: "xbuild ss_backend_assess.sln"
- Run Program: "mono ss_backend_assess/bin/Debug/ss_backend_assess.exe"

## Program Flow and Assumption
**There are 3 logins those can be used:**
- ID: user | Pass: user (User)
- ID: customer | Pass: customer (User)
- ID: admin | Pass: admin (Admin)

**Assumptions:**
- **USER** When in "Order Confirmation" window, user able to back to main menu before submitting order.
- **USER** After user Submit the order, user can't back and must proceed through
- **USER** After submitting order, user must pay and submit payment proof directly
- **USER** Coupon validity is checked on "Order Confirmation" window
- **USER** Product availability is checked on "Order Confirmation" window
- **Admin** After approving an order, admin must ship and input the shipment ID for next step

**Database Tables:**
There are 5 tables included in Database (ss_backend_db.db)
- **tblLogin** Contains Login and Password Info (U: user | A:admin)
- **tblProductData** Contains Products' info + Quantity
- **tblCoupon** Coupon info, discount type, expiry date, and quantity
- **tblOrderMaster** User order detail, approval status, shipment status + shipment ID
- **tblOrderDetail** Relational table with tblOrderMaster, this table lists all products order
You can check and modify the values with "DB Browser for SQLite"

**Abstraction Layer Model:**
This Project is using modified "Model-View-Controller" abstraction model as described below:

**DB** <--> Layer:Model <--> Layer:Presenter <--> Layer:Interface <--> **User Interface**

**Additional Info:**
- You can check the project and scripts via "MonoDevelop", open "ss_backend_assess.sln"

## Change Logs
**20160817_v0001**
Initial Push for MonoDevelop Framework

**20160818_v0002**
Login Form + DB File for SQLite

**20160818_v0003**
All Menu Front-ends (GUI) | Commons Folder --> Class as Session Variables

**20160818_v0004**
User Side Menu Development (frmMainUser, frmConfirmOrder)

**20160818_v0005**
User Side Menu Development (frmConfirmOrder + coupon use)

**20160818_v0006**
User Side Menu Development (frmConfirmOrder, stock check + frmPayment Input and Confirmation)

**20160818_v0007**
User Side Menu Development (Complete)

**20160818_v0008**
Admin Side Init Development

**20160819_v0009**
Admin Side Menu Development (frmAdminOrderDetail, frmAdminOrderList)

**20160819_v0010**	
Admin Side Menu Development (Complete)

**20160819_v0011**	
All Requirement Complete - Proceed to QA

**20160819_v0012**	
- Multiple user login
- Logout capability
- Windows will be closed if the process goes to next step
- Session will be reset every time order success

**20160819_v0013**	
- Admin Menu: After set order to shipped, menu didn't back to Main Menu
- Additional Code Documentations

**20160819_v0014**
- Additional Code Documentations
- Additional Project and Code Cleaning

**20160819_v0015**
- Add Shell Script for Mono Develop + SQLite addins install
- Add Shell Script for Build + Exec Programs

**20160820_v0016**
- Order List Menu Admin: Exception Bug Fixed when Payment Proof Image Loaded
- Payment Proof Confirmation: Final Price has added to description
- Show User Order List: Close Button has been added and worked

**20160820_v0017**
- User Main Menu: User able to clear Cart
- Admin Process Ship: Additional Validation for Blank input Shipment ID
- All Menu: Window Title has been properly changed (not using placehorder name)
- User Order Confirmation Menu: User able to back to Main Menu
- Sessions: Session will now refresh only when login is success and after completing order

**20160820_v0018**
- Final Commit
