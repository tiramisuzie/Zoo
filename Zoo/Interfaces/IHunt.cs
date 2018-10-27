using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IHunt
    {
        /// <summary>
        /// property
        /// </summary>
        int Energy { get; set; }

        /// <summary>
        /// method
        /// </summary>
        /// <returns>string</returns>
        string Weapon();
    }
}
