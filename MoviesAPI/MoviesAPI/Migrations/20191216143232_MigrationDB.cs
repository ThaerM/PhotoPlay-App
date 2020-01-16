using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesAPI.Migrations
{
    public partial class MigrationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moviesComingSoonDB",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    year = table.Column<int>(unicode: false, maxLength: 50, nullable: true),
                    genres = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ratings = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    poster = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    contentRating = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    duration = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    releaseDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    averageRating = table.Column<int>(unicode: false, maxLength: 50, nullable: true),
                    originalTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    storyline = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    actors = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    imdbRating = table.Column<double>(unicode: false, maxLength: 50, nullable: true),
                    posterurl = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moviesComingSoonDB", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MoviesInTheaters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actors = table.Column<string>(nullable: true),
                    averageRating = table.Column<int>(nullable: true),
                    contentRating = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    genres = table.Column<string>(nullable: true),
                    imdbRating = table.Column<double>(nullable: true),
                    originalTitle = table.Column<string>(nullable: true),
                    poster = table.Column<string>(nullable: true),
                    posterurl = table.Column<string>(nullable: true),
                    ratings = table.Column<int>(nullable: true),
                    releaseDate = table.Column<string>(nullable: true),
                    storyline = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesInTheaters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topRatedIndian1",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: true),
                    genres = table.Column<string>(nullable: true),
                    ratings = table.Column<int>(nullable: true),
                    poster = table.Column<string>(nullable: true),
                    contentRating = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    releaseDate = table.Column<string>(nullable: true),
                    averageRating = table.Column<int>(nullable: true),
                    originalTitle = table.Column<string>(nullable: true),
                    storyline = table.Column<string>(nullable: true),
                    actors = table.Column<string>(nullable: true),
                    imdbRating = table.Column<double>(nullable: true),
                    posterurl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topRatedIndian1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topRatedIndian2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: true),
                    genres = table.Column<string>(nullable: true),
                    ratings = table.Column<int>(nullable: true),
                    poster = table.Column<string>(nullable: true),
                    contentRating = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    releaseDate = table.Column<string>(nullable: true),
                    averageRating = table.Column<int>(nullable: true),
                    originalTitle = table.Column<string>(nullable: true),
                    storyline = table.Column<string>(nullable: true),
                    actors = table.Column<string>(nullable: true),
                    imdbRating = table.Column<double>(nullable: true),
                    posterurl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topRatedIndian2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topRatedMovies1",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actors = table.Column<string>(nullable: true),
                    averageRating = table.Column<int>(nullable: true),
                    contentRating = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    genres = table.Column<string>(nullable: true),
                    imdbRating = table.Column<double>(nullable: true),
                    originalTitle = table.Column<string>(nullable: true),
                    poster = table.Column<string>(nullable: true),
                    posterurl = table.Column<string>(nullable: true),
                    ratings = table.Column<string>(nullable: true),
                    releaseDate = table.Column<string>(nullable: true),
                    storyline = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topRatedMovies1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topRatedMovies2",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    year = table.Column<int>(unicode: false, maxLength: 50, nullable: true),
                    genres = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ratings = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    poster = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    contentRating = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    duration = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    releaseDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    averageRating = table.Column<int>(unicode: false, maxLength: 50, nullable: true),
                    originalTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    storyline = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    actors = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    imdbRating = table.Column<double>(unicode: false, maxLength: 50, nullable: true),
                    posterurl = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topRatedMovies2", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "moviesComingSoonDB");

            migrationBuilder.DropTable(
                name: "MoviesInTheaters");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "topRatedIndian1");

            migrationBuilder.DropTable(
                name: "topRatedIndian2");

            migrationBuilder.DropTable(
                name: "topRatedMovies1");

            migrationBuilder.DropTable(
                name: "topRatedMovies2");
        }
    }
}
