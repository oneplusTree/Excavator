//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Excavator.F1
{
    using System;
    using System.Collections.Generic;

    public partial class Requirement
    {
        public Nullable<int> Individual_ID { get; set; }

        public string Requirement_Name { get; set; }

        public string Requirement_Date { get; set; }

        public string Requirement_Status_Name { get; set; }

        public string Requirement_Note { get; set; }

        public Nullable<bool> Is_Confidential { get; set; }

        public Nullable<bool> Is_Background_Check { get; set; }

        public Nullable<bool> Is_Reference_Check { get; set; }

        public Nullable<int> Individual_Requirement_ID { get; set; }

        public byte[] Requirement_Document { get; set; }

        public string Requirement_Document_Content_Type { get; set; }

        public string Requirement_Document_File_Extension { get; set; }

        public string UserName { get; set; }
    }
}
