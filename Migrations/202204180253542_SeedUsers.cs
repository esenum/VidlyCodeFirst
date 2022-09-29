namespace VidlyCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'750110aa-9887-48a3-a7c9-57f55f5ae8a4', N'esenum@itu.edu.tr', 0, N'AG0rJW16nG/Zbw5VTVqu2IokLc3ZqO6FebVg/Q1i03tQWoGmvU23i3ERT57ID6lKMA==', N'b557562d-187f-410e-96e9-7d7b5f57e102', NULL, 0, 0, NULL, 1, 0, N'esenum@itu.edu.tr')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f58c9ef4-a4b9-4a74-b9cb-312e4fd5e4e2', N'qwerty@vidly.com', 0, N'AAa+cp49BPQgaHUnu29wVqHApSbdbMulN5ir4sq3D2JXLXiLZpwwfWGAcaTnvXatCw==', N'55ba2ef6-48e7-4032-bb73-9cab500ace8d', NULL, 0, 0, NULL, 1, 0, N'qwerty@vidly.com')

");
        }
        
        public override void Down()
        {
        }
    }
}

//INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')
//INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
