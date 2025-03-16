using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace AllianzSampleXaf.Module.BusinessObjects;

[DefaultProperty(nameof(FullName))]
public class Employee : BaseObject
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public string FullName =>
        ObjectFormatter.Format("{FirstName} {LastName}",
            this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
}