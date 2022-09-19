namespace Entity_FrameWork_CodeFirst_First.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entity_FrameWork_CodeFirst_First.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Entity_FrameWork_CodeFirst_First.Models.RecordContext";
        }

        protected override void Seed(Entity_FrameWork_CodeFirst_First.Models.RecordContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
