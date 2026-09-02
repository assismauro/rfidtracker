# RFIDTracker

RFIDTracker is a Windows Forms (.NET Framework) desktop application for tracking RFID-tagged items, built with DevExpress WinForms UI controls and an ODBC-backed database.

## Requirements

- **Windows** (WinForms desktop app)
- **Visual Studio 2017** or later (any edition), with the **.NET desktop development** workload
- **.NET Framework 4.6.1** Developer Pack
- **DevExpress WinForms v16.1** controls installed and licensed (referenced assemblies: `DevExpress.XtraBars`, `DevExpress.XtraGrid`, `DevExpress.XtraEditors`, `DevExpress.XtraLayout`, `DevExpress.XtraPrinting`, `DevExpress.BonusSkins`, `DevExpress.Sparkline`, `DevExpress.Data`, `DevExpress.Utils`, `DevExpress.Printing.Core`, all v16.1) — these are not restored via NuGet, so the DevExpress installer must register them in the GAC/reference assemblies before the project will build
- An **ODBC driver** for your target database, plus a configured ODBC Data Source Name (DSN) — the app connects via `System.Data.Odbc`

## Getting the code

```bash
git clone https://github.com/assismauro/rfidtracker.git
cd rfidtracker
```

## Database setup

1. Create (or point to) the database the app should use.
2. Register an ODBC DSN for it (Windows: **ODBC Data Sources** admin tool → System DSN).
3. Set the connection string, either:
   - as a `Dsn=<name>;uid=<user>;pwd=<password>` value, or
   - as a full ODBC connection string,

   in `RFIDTracker/Properties/Settings.settings` (setting `RFIDTracker`) or directly in `RFIDTracker/app.config` under `connectionStrings`. See `RFIDTracker/db.cs` for how the value is read (a `Dsn=` prefix is used as-is; anything else is treated as encrypted and decrypted at startup).

   > The credentials currently checked into `Settings.settings`/`app.config` are placeholders from development and should be replaced with your own environment's values — do not reuse them for a real deployment.

## Building

### Visual Studio

1. Open `RFIDTracker.sln`.
2. Select the `Debug` or `Release` configuration (`Any CPU`).
3. Build → Build Solution (`Ctrl+Shift+B`).

### Command line (MSBuild)

From a **Developer Command Prompt for VS**:

```bat
msbuild RFIDTracker.sln /p:Configuration=Release /p:Platform="Any CPU"
```

Build output is written to `RFIDTracker/bin/<Debug|Release>/`.

## Running

Run the built `RFIDTracker.exe` from the output folder, or press `F5` in Visual Studio. On launch, the app connects to the database via the configured ODBC DSN — make sure it's reachable before starting.
