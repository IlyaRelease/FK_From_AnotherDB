# FK_From_AnotherDB
https://app.diagrams.net/#G1YzAC67f_lGXXoK4R3nu_FjylV_FkZjtJ

This solution use PostgreeSQL

To add migrations use this commands:
add-migration Scada -context ScadaDbContext;
add-migration Configurator -context ConfDBContext;

To add db use this commands:
update-database -context ScadaDbContext
update-database -context ConfDBContext