﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=1.1.4322.573.
// 
namespace Ankh.Config {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ankhsvn.com/Config.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ankhsvn.com/Config.xsd", IsNullable=false)]
    public class Config {
        
        /// <remarks/>
        public ConfigRepositoryExplorer RepositoryExplorer;
        
        /// <remarks/>
        public ConfigSubversion Subversion;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ankhsvn.com/Config.xsd")]
    public class ConfigRepositoryExplorer {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Url")]
        public ConfigRepositoryExplorerUrl[] MruUrls;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ankhsvn.com/Config.xsd")]
    public class ConfigRepositoryExplorerUrl {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ankhsvn.com/Config.xsd")]
    public class ConfigSubversion {
        
        /// <remarks/>
        public string ConfigDir;
    }
}
