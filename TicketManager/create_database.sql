CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;
CREATE TABLE "Employees" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Employees" PRIMARY KEY AUTOINCREMENT,
    "name" TEXT NOT NULL,
    "cpf" INTEGER NOT NULL,
    "situation" TEXT NOT NULL,
    "DateEdit" TEXT NOT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250408021439_InitialCreate', '9.0.3');

CREATE TABLE "Tickets" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Tickets" PRIMARY KEY AUTOINCREMENT,
    "employeeId" INTEGER NOT NULL,
    "quantity" INTEGER NOT NULL,
    "situation" TEXT NOT NULL,
    "dateEdit" TEXT NOT NULL
);

CREATE TABLE "ef_temp_Employees" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Employees" PRIMARY KEY AUTOINCREMENT,
    "DateEdit" TEXT NOT NULL,
    "cpf" TEXT NOT NULL,
    "name" TEXT NOT NULL,
    "situation" TEXT NOT NULL
);

INSERT INTO "ef_temp_Employees" ("id", "DateEdit", "cpf", "name", "situation")
SELECT "id", "DateEdit", "cpf", "name", "situation"
FROM "Employees";

COMMIT;

PRAGMA foreign_keys = 0;

BEGIN TRANSACTION;
DROP TABLE "Employees";

ALTER TABLE "ef_temp_Employees" RENAME TO "Employees";

COMMIT;

PRAGMA foreign_keys = 1;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250409021529_TicketsUpgrade', '9.0.3');

