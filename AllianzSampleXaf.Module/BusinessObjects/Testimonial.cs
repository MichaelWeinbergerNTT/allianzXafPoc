﻿using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace AllianzSampleXaf.Module.BusinessObjects;

[NavigationItem("Marketing")]
public class Testimonial : BaseObject
{
    [FieldSize(FieldSizeAttribute.Unlimited)]
    public virtual string Quote { get; set; }

    [FieldSize(512)]
    public virtual string Highlight { get; set; }


    [HideInUI(HideInUI.ListView)]
    public virtual DateTime CreatedOn { get; set; }

    public virtual string Tags { get; set; }

    public virtual IList<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

}
