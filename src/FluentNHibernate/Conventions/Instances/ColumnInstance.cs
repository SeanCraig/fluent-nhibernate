using System;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.MappingModel;

namespace FluentNHibernate.Conventions.Instances
{
    public class ColumnInstance : ColumnInspector, IColumnInstance
    {
        private readonly ColumnMapping mapping;

        public ColumnInstance(Type parentType, ColumnMapping mapping)
            : base(parentType, mapping)
        {
            this.mapping = mapping;
        }

        public new void Length(int length)
        {
            mapping.Set(x => x.Length, Layer.Conventions, length);
        }
    }
}