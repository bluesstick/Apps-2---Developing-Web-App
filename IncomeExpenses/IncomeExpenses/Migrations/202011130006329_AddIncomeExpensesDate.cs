namespace IncomeExpenses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIncomeExpensesDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IncomeExpensesEMs", "DateIncome", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IncomeExpensesEMs", "DateIncome");
        }
    }
}
