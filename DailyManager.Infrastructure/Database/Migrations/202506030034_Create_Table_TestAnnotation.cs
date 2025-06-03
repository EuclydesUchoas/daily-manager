using FluentMigrator;

namespace DailyManager.Infrastructure.Database.Migrations
{
    [Migration(202506030034, "Create TestAnnotation table")]
    public sealed class _202506030034_Create_Table_TestAnnotation : Migration
    {
        public override void Up()
        {
            Create.Table("TestAnnotation")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(5000).Nullable()
                .WithColumn("CreatedAt").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime);
        }

        public override void Down()
        {
            Delete.Table("TestAnnotation");
        }
    }
}
