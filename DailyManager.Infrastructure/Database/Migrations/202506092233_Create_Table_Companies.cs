using FluentMigrator;

namespace DailyManager.Infrastructure.Database.Migrations
{
    [Migration(202506092233, "Create Companies Table")]
    public sealed class _202506092233_Create_Table_Companies : Migration
    {
        public override void Up()
        {
            Create.Table("Companies")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("CNPJ").AsString(18).Nullable()
                .WithColumn("Name").AsString(100).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Companies");
        }
    }
}
