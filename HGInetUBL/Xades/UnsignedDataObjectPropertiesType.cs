﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGInetUBL.Xades
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("UnsignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class UnsignedDataObjectPropertiesType
    {

        private AnyType[] unsignedDataObjectPropertyField;

        private string idField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperty")]
        public AnyType[] UnsignedDataObjectProperty
        {
            get
            {
                return this.unsignedDataObjectPropertyField;
            }
            set
            {
                this.unsignedDataObjectPropertyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}