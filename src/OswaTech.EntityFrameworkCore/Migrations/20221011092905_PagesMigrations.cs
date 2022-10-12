using Microsoft.EntityFrameworkCore.Migrations;
using OswaTech.AboutUsPageModel;
using OswaTech.Dto;

#nullable disable

namespace OswaTech.Migrations
{
    public partial class PagesMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "AboutUsCompanyPurposesImageDb",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  AboutUsCompanyPurposesImagesUrl = table.Column<string>(type: "Varchar(Max)", nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_AboutUsCompanyPurposesImageDb", x => x.Id);
              });

            migrationBuilder.CreateTable(
              name: "AboutUsCompanyMessageImagesDb",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  AboutUsCompanyMessageImagesUrl = table.Column<string>(type: "Varchar(Max)", nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_AboutUsCompanyMessageImagesDb", x => x.Id);
              });

            migrationBuilder.CreateTable(
                name: "AboutUsDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUsBackGroundUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutUsTitleArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutUsTitleEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutUsCompanyMessageImagesId = table.Column<string>(type: "int", nullable: false),
                    FirstAddressEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstAddressArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutUsCompanyPurposesImagesId = table.Column<string>(type: "int", nullable: false),
                    SecondAddressArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondAddressEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstContentEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstContentArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondContentArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondContentEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsDb", x => x.Id);

                    table.ForeignKey(
                    name: "FK_AboutUsCompanyMessageImagesId",
                    column: x => x.AboutUsCompanyMessageImagesId,
                    principalTable: "AboutUsCompanyMessageImagesDb",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);

                    table.ForeignKey(
                    name: "FK_AboutUsCompanyPurposesImagesId",
                    column: x => x.AboutUsCompanyPurposesImagesId,
                    principalTable: "AboutUsCompanyPurposesImageDb",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
               name: "BusinessImagesDb",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   BusinessModelImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_BusinessImagesDb", x => x.Id);
               });

            migrationBuilder.CreateTable(
                name: "businessesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessModelImageId = table.Column<int>(type: "int", nullable: false),
                    BusinessModelTitleArabic = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BusinessModelTitleEnglish = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BusinessModelDescriptionsEnglish = table.Column<string>(type: "varchar(max)", nullable: false),
                    BusinessModelDescriptionsArabic = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_businessesDb", x => x.Id);

                    table.ForeignKey(
                    name: "FK_BusinessModelImageId",
                    column: x => x.BusinessModelImageId,
                    principalTable: "BusinessImagesDb",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                });

           

            migrationBuilder.CreateTable(
                name: "FooterDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterImageLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooterContentArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooterContentEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaceBookLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelegramLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneImagesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneImagesDb", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "HomeDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeBackGroundUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneImageId = table.Column<int>(type: "int", nullable: false),
                    ButtonLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeTextTitleArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HomeTextTitleEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HomeTextDescriptionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeTextDescriptionArabic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeDb", x => x.Id);

                    table.ForeignKey(
                    name: "FK_PhoneImageId",
                    column: x => x.PhoneImageId,
                    principalTable: "PhoneImagesDb",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                });



            migrationBuilder.CreateTable(
                name: "ProccessImagesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProccessImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProccessImagesDb", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "ProccessDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProccessImageId = table.Column<int>(type: "int", nullable: false),
                    ProccessTitleArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProccessTitleEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProccessDescriptionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProccessDescriptionArabic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProccessDb", x => x.Id);

                    table.ForeignKey(
                   name: "FK_ProccessImageId",
                   column: x => x.ProccessImageId,
                   principalTable: "ProccessImagesDb",
                   principalColumn: "Id",
                   onDelete: ReferentialAction.Cascade);
                });

            
            migrationBuilder.CreateTable(
                name: "ServiceImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicesDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceImageId = table.Column<int>(type: "int", nullable: false),
                    ServiceTitleArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceTitleEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceDescriptionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescriptionArabic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesDb", x => x.Id);

                    table.ForeignKey(
                   name: "FK_ServiceImageId",
                   column: x => x.ServiceImageId,
                   principalTable: "ServiceImages",
                   principalColumn: "Id",
                   onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsDb");

            migrationBuilder.DropTable(
                name: "businessesDb");

            migrationBuilder.DropTable(
                name: "BusinessImagesDb");

            migrationBuilder.DropTable(
                name: "FooterDb");

            migrationBuilder.DropTable(
                name: "HomeDb");

            migrationBuilder.DropTable(
                name: "PhoneImagesDb");

            migrationBuilder.DropTable(
                name: "ProccessDb");

            migrationBuilder.DropTable(
                name: "ProccessImagesDb");

            migrationBuilder.DropTable(
                name: "ServiceImages");

            migrationBuilder.DropTable(
                name: "ServicesDb");
        }
    }
}
