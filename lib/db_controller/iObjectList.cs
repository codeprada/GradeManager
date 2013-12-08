using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_DB_Controller
{
    public class iObjectList : ICollection<iObject>
    {
        protected List<iObject> ObjectList;

        public iObjectList()
        {
            ObjectList = new List<iObject>();
        }

        public iObjectList(iObjectList iol)
        {
            ObjectList = new List<iObject>(iol);
        }

        public virtual iObject this[int index]
        {
            get
            {
                var buffer = ObjectList.Where(x => x.ID == index).Select(x => x);
                if (buffer.Count() > 0)
                    return buffer.First();
                else
                    return null;
            }
        }

        public virtual iObject IndexOf(int index)
        {
            return ObjectList[index];
        }

        public virtual int Count
        {
            get
            {
                return ObjectList.Count;
            }
        }

        public virtual void Add(iObject weight_obj)
        {
            ObjectList.Add(weight_obj);

        }

        public virtual bool IsReadOnly
        {
            get { return false; }
        }

        public virtual bool Remove(int id)
        {
            return ObjectList.Remove(this[id]);
        }

        public virtual bool Remove(iObject w)
        {
            return ObjectList.Remove(w);
        }

        public virtual void Clear()
        {
            ObjectList.Clear();
        }

        public virtual void Insert(int index, iObject w)
        {
            ObjectList.Insert(index, w);
        }

        public virtual int IndexOf(iObject w)
        {
            return ObjectList.IndexOf(w);
        }

        public virtual void Reverse()
        {
            ObjectList.Reverse();

        }

        public void Move(int position, int ID)
        {
            iObject temp = this[ID];
            Insert(position, temp);
            Remove(this[ID]);
        }

        public virtual void CopyTo(iObject[] wl)
        {
            ObjectList.CopyTo(wl);
        }

        public virtual void CopyTo(iObjectList ol)
        {
            ol.ObjectList = new List<iObject>(ObjectList);
        }

        public virtual void CopyTo(iObject[] wl, int index)
        {
            ObjectList.CopyTo(wl, index);
        }

        public virtual IEnumerator<iObject> GetEnumerator()
        {
            foreach (iObject w in ObjectList)
                yield return w;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (iObject w in ObjectList)
                yield return w;
        }

        public virtual bool Contains(iObject w)
        {
            return ObjectList.Contains(w);

        }

        public virtual bool Contains(int ID)
        {
            return this[ID] != null;
        }
    }
}
