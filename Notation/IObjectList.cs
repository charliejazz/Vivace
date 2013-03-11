using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObjectList<T> {
        /// <summary>
        /// Add an object to the list
        /// </summary>
        /// <param name="obj"></param>
        void Add(T obj);
        /// <summary>
        /// Remove an object to the list
        /// </summary>
        /// <param name="obj"></param>
        void Remove(T obj);
        /// <summary>
        /// provides Access to the list via index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; set; }
        /// <summary>
        /// provides Access to the list object itself
        /// </summary>
        List<T> InnerList { get; }
    }
}
