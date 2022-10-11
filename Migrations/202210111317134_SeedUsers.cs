namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a14f3c34-9afa-4b3b-a0ac-34c7e8bfb640', N'admin@vidly.com', 0, N'AEUeb6omOcuqKfb5N8Op4ti2jXZXZq9WnVwP1JpVjmsOZnCDu9SQr+zdbjrIObapPQ==', N'9c12f5bf-80ab-41be-8db9-c48c2c4a89e4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e93736ab-c1bd-4e2a-9cb8-d8974f297acb', N'ghost@vidly.com', 0, N'AG0cDnV8gWBy9MpkSL1Qg7+N2/2ZM6+qvCknkTUpPZ5XAmdm0EupZN3i8ByQoyTXyQ==', N'e88d603d-af13-4795-9121-f81ae40300db', NULL, 0, 0, NULL, 1, 0, N'ghost@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2a50da58-a893-433e-8efe-e32c5ca661dd', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a14f3c34-9afa-4b3b-a0ac-34c7e8bfb640', N'2a50da58-a893-433e-8efe-e32c5ca661dd')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
