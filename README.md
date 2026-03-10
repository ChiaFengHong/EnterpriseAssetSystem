# EnterpriseAssetSystem

🚀 **Enterprise Asset Management System (Back-end)**


---
## 專案架構
<img width="187" height="233" alt="image" src="https://github.com/user-attachments/assets/89eb9ff3-c526-4e30-b381-e9400685e9cf" />

---
## 核心功能

- **Entities**
  - Employee
  - AssetAccount
  - TransactionLog
- **DbContext**
  - AppDbContext
  - 支援 EF Core Migration
- **資料庫**
  - SQL Server LocalDB
  - Tables 自動生成 via Migration

---

## 使用方式

1. Clone 專案
git clone https://github.com/ChiaFengHong/EnterpriseAssetSystem.git

2. 安裝套件
dotnet restore

3. 建立資料庫
dotnet ef database update

4. 執行專案
dotnet run

5. 打開 Swagger UI
https://localhost:<port>/swagger/index.html

技術細節
-----------------
- .NET 8 / ASP.NET Core Web API
- Entity Framework Core
- SQL Server LocalDB
- Minimal API 架構
- Clean architecture 資料夾分層（Entities / DTOs / Repositories / Services / Configurations）
---

Git Commit 規範
-----------------
- feat: 新增功能
- fix: 修正問題
- docs: 文件修改
- chore: 其他雜項<br />

今天 commit 條列：
1. feat: initialize ASP.NET Core Web API project
2. feat: add enterprise project folder structure
3. feat: add core domain entities
4. feat: configure Entity Framework DbContext
5. feat: add initial EF Core migration and generate tables
6. docs: add project README with setup instructions
---
下一步計畫
-----------------
- Repository Pattern
- Service Layer
- RESTful API
- 資產轉移 Transaction
