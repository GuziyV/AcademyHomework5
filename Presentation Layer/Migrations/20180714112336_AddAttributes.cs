using Microsoft.EntityFrameworkCore.Migrations;

namespace PresentationLayer.Migrations
{
    public partial class AddAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Pilots_PilotId",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Crews_CrewId",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Stewardesses_Crews_CrewId",
                table: "Stewardesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_FlightNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "RaceNumber",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "RaceNumber",
                table: "Departures",
                newName: "PlaneId");

            migrationBuilder.AlterColumn<int>(
                name: "FlightNumber",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Stewardesses",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stewardesses",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Stewardesses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "PlaneTypes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaneTypeId",
                table: "Planes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Pilots",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pilots",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartureFrom",
                table: "Flights",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Departures",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightNumber",
                table: "Departures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PilotId",
                table: "Crews",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departures_FlightNumber",
                table: "Departures",
                column: "FlightNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Departures_PlaneId",
                table: "Departures",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Pilots_PilotId",
                table: "Crews",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Crews_CrewId",
                table: "Departures",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Flights_FlightNumber",
                table: "Departures",
                column: "FlightNumber",
                principalTable: "Flights",
                principalColumn: "Number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Planes_PlaneId",
                table: "Departures",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes",
                column: "PlaneTypeId",
                principalTable: "PlaneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stewardesses_Crews_CrewId",
                table: "Stewardesses",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Flights_FlightNumber",
                table: "Tickets",
                column: "FlightNumber",
                principalTable: "Flights",
                principalColumn: "Number",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Pilots_PilotId",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Crews_CrewId",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Flights_FlightNumber",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Planes_PlaneId",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Stewardesses_Crews_CrewId",
                table: "Stewardesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_FlightNumber",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Departures_FlightNumber",
                table: "Departures");

            migrationBuilder.DropIndex(
                name: "IX_Departures_PlaneId",
                table: "Departures");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                table: "Departures");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Departures",
                newName: "RaceNumber");

            migrationBuilder.AlterColumn<int>(
                name: "FlightNumber",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RaceNumber",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Stewardesses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stewardesses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Stewardesses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "PlaneTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "PlaneTypeId",
                table: "Planes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Pilots",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pilots",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DepartureFrom",
                table: "Flights",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Departures",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PilotId",
                table: "Crews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Pilots_PilotId",
                table: "Crews",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Crews_CrewId",
                table: "Departures",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes",
                column: "PlaneTypeId",
                principalTable: "PlaneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stewardesses_Crews_CrewId",
                table: "Stewardesses",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Flights_FlightNumber",
                table: "Tickets",
                column: "FlightNumber",
                principalTable: "Flights",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
