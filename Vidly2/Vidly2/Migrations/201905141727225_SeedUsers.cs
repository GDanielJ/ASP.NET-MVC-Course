namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6e12b3db-00e8-4a7d-9c1a-6ddf29b9d4ed', N'admin@vidly.com', 0, N'APgR24YFE54In7TnEmldGwGFRgncH77KhVLxDuady2iJMrR+O63us1RYrbmD1gegww==', N'e94b29e8-215d-4d92-bb16-2b7f0a8e7c72', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'78735b0b-3460-4aea-a40f-6af8ca39c5a0', N'guest@vidly.com', 0, N'AGkP8e0B2sDb1X1EhqifleIemDPttgYYTsqWBBJ6hpEEe9hG0sknRUV9tZKmd8EBGg==', N'c814d7b1-4487-4298-ab53-be3c5261052a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7caa6441-ee91-4fe2-a83e-fd41c939418b', N'CanManageMovies')

INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6e12b3db-00e8-4a7d-9c1a-6ddf29b9d4ed', N'7caa6441-ee91-4fe2-a83e-fd41c939418b')

");
        }
        
        public override void Down()
        {
        }
    }
}
