# Getting Started
1. Download project and open visual studios
2. Open nuget package manager console and run Update-Database
3. To populate with fake companies, locations, and reviews, sign in to admin account. The login is admin@gmail.com and Admin123!

## Settings
1. Mongo connection string can be customized in the MongoService.cs file
2. Mongo database and collection name can be customized in the Program.cs file
3. Imgbb Api key MUST be added to ImgbbService.cs file, in the constructor, or changing images won't work

# Pictures
![HomePage](./Images/HomePage.png)
![Query](./Images/Query.png)
![CompanyPage](./Images/CompanyPage.png)
![LocationPage](./Images/LocationPage.png)
