using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL
{
    public abstract  class clTableBase<T>
    {
        /// <summary>
        /// Get a list of entities from database 
        /// </summary>
        /// <returns>List of the T object</returns>
        public abstract List<T> GetEntityList();

        /// <summary>
        /// Get a Datatable contain all records of the entity
        /// </summary>
        /// <returns>Datatable of the entity data</returns>
        public abstract DataTable GetEntityDatatable();

        /// <summary>
        /// Insert a new entity in the data base
        /// </summary>
        /// <param name="Entity"></param>
        public abstract void InsertEntity();

        /// <summary>
        /// Update an existing entity on database
        /// </summary>
        /// <param name="Entity"></param>
        public abstract void UpdateEntity();

        /// <summary>
        /// Delete an Entity on Database
        /// </summary>
        /// <param name="Entity"></param>
        public abstract void DeleteEntity();


    }
}
