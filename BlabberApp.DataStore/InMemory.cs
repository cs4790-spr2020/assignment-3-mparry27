using System;
using System.Collections;
using BlabberApp.Domain.Entities;
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.DataStore
{
    public class InMemory : IRepository
    {
        private ArrayList _items;

        public InMemory()
        {
            this._items = new ArrayList();
        }
        /*
        public bool Create(IDatum datum)
        {
            int idx = this._items.Add(datum);
            if (idx < 0)
            {
                throw new ArgumentOutOfRangeException("OH HELL!");
            }
            return true;
        }
        public IDatum Read(int idx)
        {
            return (BlabberApp.Domain.Interface IDatum)this._items[idx];
        }
        public bool Update(IDatum datum)
        {
            return true;
        }
        public bool Delete(int idx)
        {
            try
            {
                this._items.RemoveAt(idx);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw e;
            }
            return true;
        }
        */

        T Add<T>(T item) where T : BaseDatum
        {
            return item;
        }
        void Delete<T>(T item) where T : BaseDatum
        {

        }
        List<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseDatum
        {
            return;
        }
        T GetById<T>(string sysId) where T : BaseDatum
        {
            return BaseDatum;
            void Update<T>(T item) where T : BaseDatum { }
        }
    }
