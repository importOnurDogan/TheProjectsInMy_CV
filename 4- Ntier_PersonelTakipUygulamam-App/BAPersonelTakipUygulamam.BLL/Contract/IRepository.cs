﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAPersonelTakipUygulamam.BLL.Contract
{
    public interface IRepository <T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int id);
    }
}
