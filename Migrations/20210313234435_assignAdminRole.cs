using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementReservation.Migrations
{
    public partial class assignAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO UserRoles (UserId , RoleId ) VALUES ('7e157250-d8f3-4d3c-9067-86c524cfedd7' , 'b0cfc8ab-9886-4cb5-9054-6f8dcb3e498c')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete FROM UserRoles where UserId = '7e157250-d8f3-4d3c-9067-86c524cfedd7'");
        }
    }
}
