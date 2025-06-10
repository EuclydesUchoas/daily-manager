using FluentMigrator;

namespace DailyManager.Infrastructure.Database.Migrations
{
    [Migration(202506092235, "Create Dailies Table")]
    public sealed class _202506092235_Create_Table_Dailies : Migration
    {
        public override void Up()
        {
            Create.Table("Dailies")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("CompanyId").AsGuid().NotNullable().ForeignKey("Companies", "Id")
                .WithColumn("Date").AsDate().NotNullable()
                .WithColumn("Title").AsString(100).NotNullable()
                .WithColumn("Description").AsString(10000).Nullable()
                .WithColumn("CreatedAt").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime)
                .WithColumn("UpdatedAt").AsDateTime().Nullable();
        }

        public override void Down()
        {
            Delete.Table("Dailies");
        }
    }
}
