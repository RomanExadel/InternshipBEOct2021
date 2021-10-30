using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangeCollectionNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_AspNetUsers_UserId",
                table: "CandidateUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_Candidates_CandidateId",
                table: "CandidateUser");

            migrationBuilder.DropForeignKey(
                name: "FK_InternshipUser_AspNetUsers_UserId",
                table: "InternshipUser");

            migrationBuilder.DropForeignKey(
                name: "FK_InternshipUser_Internships_InternshipId",
                table: "InternshipUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_AspNetUsers_UserId",
                table: "TeamUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_Teams_TeamId",
                table: "TeamUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TeamUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "TeamUser",
                newName: "TeamsId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamUser_UserId",
                table: "TeamUser",
                newName: "IX_TeamUser_UsersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "InternshipUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "InternshipId",
                table: "InternshipUser",
                newName: "InternshipsId");

            migrationBuilder.RenameIndex(
                name: "IX_InternshipUser_UserId",
                table: "InternshipUser",
                newName: "IX_InternshipUser_UsersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CandidateUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "CandidateUser",
                newName: "CandidatesId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateUser_UserId",
                table: "CandidateUser",
                newName: "IX_CandidateUser_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_AspNetUsers_UsersId",
                table: "CandidateUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_Candidates_CandidatesId",
                table: "CandidateUser",
                column: "CandidatesId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternshipUser_AspNetUsers_UsersId",
                table: "InternshipUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternshipUser_Internships_InternshipsId",
                table: "InternshipUser",
                column: "InternshipsId",
                principalTable: "Internships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_AspNetUsers_UsersId",
                table: "TeamUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_Teams_TeamsId",
                table: "TeamUser",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_AspNetUsers_UsersId",
                table: "CandidateUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_Candidates_CandidatesId",
                table: "CandidateUser");

            migrationBuilder.DropForeignKey(
                name: "FK_InternshipUser_AspNetUsers_UsersId",
                table: "InternshipUser");

            migrationBuilder.DropForeignKey(
                name: "FK_InternshipUser_Internships_InternshipsId",
                table: "InternshipUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_AspNetUsers_UsersId",
                table: "TeamUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_Teams_TeamsId",
                table: "TeamUser");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "TeamUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TeamsId",
                table: "TeamUser",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamUser_UsersId",
                table: "TeamUser",
                newName: "IX_TeamUser_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "InternshipUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "InternshipsId",
                table: "InternshipUser",
                newName: "InternshipId");

            migrationBuilder.RenameIndex(
                name: "IX_InternshipUser_UsersId",
                table: "InternshipUser",
                newName: "IX_InternshipUser_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "CandidateUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CandidatesId",
                table: "CandidateUser",
                newName: "CandidateId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateUser_UsersId",
                table: "CandidateUser",
                newName: "IX_CandidateUser_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_AspNetUsers_UserId",
                table: "CandidateUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_Candidates_CandidateId",
                table: "CandidateUser",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternshipUser_AspNetUsers_UserId",
                table: "InternshipUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternshipUser_Internships_InternshipId",
                table: "InternshipUser",
                column: "InternshipId",
                principalTable: "Internships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_AspNetUsers_UserId",
                table: "TeamUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_Teams_TeamId",
                table: "TeamUser",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
