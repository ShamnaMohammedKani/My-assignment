﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class car
    {
        private long _id;

        private string _name;

        private string _model;

        private Int32 _makeyear;

        private string _company;

        private Int32 _comfortLevel;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        public string Model

        {

            get { return _model; }

            set { _model = value; }

        }

        public Int32 Makeyear

        {

            get { return _makeyear; }

            set { _makeyear = value; }

        }

        public string Company

        {

            get { return _company; }

            set { _company = value; }

        }

        public Int32 comfortLevel

        {

            get { return _comfortLevel; }

            set

            {

                _comfortLevel = value;

            }

        }

        public car()

        {

        }

        public car(long id, string name, string model, int makeyear, string company, int comfortLevel)

        {

            Id = id;

            Name = name;

            Model = model;

            Makeyear = makeyear;

            Company = company;

            this.comfortLevel = comfortLevel;

        }

    }
}

