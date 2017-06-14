﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace eFormData
{
    #region EntityGroup
    public class EntityGroup
    {
        public EntityGroup()
        {

        }

        public EntityGroup(string name, string type, string entityGroupMUId, List<EntityItem> entityGroupItemLst, string workflowState)
        {
            Name = name;
            Type = type;
            EntityGroupMUId = entityGroupMUId;
            EntityGroupItemLst = entityGroupItemLst;
            WorkflowState = workflowState;
        }

        public string Name { get; }
        public string Type { get; }
        public string EntityGroupMUId { get; }
        public List<EntityItem> EntityGroupItemLst { get; set; }
        public string WorkflowState { get; }
    }
    #endregion

    #region EntityGroupList
    public class EntityGroupList
    {
        public EntityGroupList()
        {

        }

        public EntityGroupList(int numOfElements, int pageNum, List<EntityGroup> entityGroupList)
        {
            this.NumOfElements = numOfElements;
            this.PageNum = pageNum;
            this.EntityGroups = entityGroupList;
        }

        public int NumOfElements { get; }
        public int PageNum { get; }
        public List<EntityGroup> EntityGroups { get; }
    }
    #endregion

    #region EntityItem
    public class EntityItem
    {
        public EntityItem()
        {
            Name = "";
            Description = "";
            EntityItemUId = "";
        }

        public EntityItem(string name, string description, string entityItemUId, string workflowState)
        {
            Name = name;
            Description = description;
            EntityItemUId = entityItemUId;
            WorkflowState = workflowState;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string EntityItemUId { get; set; }
        public string WorkflowState { get; }
    }
    #endregion
}