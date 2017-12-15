using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict.Admin.Database
{
    public enum DataType
    {
        TINYINT,
        SMALLINT,
        MEDIUMINT,
        INT,
        BIGINT,
        CHAR,
        VARCHAR,
        TEXT,
        BLOB,
        BINARY,
        NUMERIC,
        DECIMAL,
        FLOAT,
        DOUBLE,
        DATE,
        TIME,
        DATETIME,
        TIMESTAMP,
        YEAR,
        BIT
    };

    class Field
    {
        public DataType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

        public bool Primary { get; set; }
        public bool Nullable { get; set; }
        public bool Unique { get; set; }


        public Field(string name, DataType type, string desc="", int size = -1, bool primary=false, bool unique=false, bool nullable=false)
        {
            Name = name;
            Description = desc;
            Type = type;
            Size = size;
            Primary = primary;
            Unique = unique;
            Nullable = nullable;
        }
    };

    class Table
    {
        private Dictionary<string, Field> _fields = null;
        public string Name{ get; protected set; }
        public Dictionary<string,Field> Fields { get { return _fields; } }
        protected Table(string name)
        {
            Name = name;
            _fields = new Dictionary<string, Field>();
        }

        public Field GetField(string name)
        {
            Field field = null;
            if((null != name) && (name.Length>0))
            {
                if(_fields.ContainsKey(name))
                {
                    return _fields[name];
                }
                else
                {
                    return null;
                }
            }
            return field;
        }

        protected Field AddField(string key, Field field)
        {
            if (_fields.ContainsKey(key))
            {
                throw new Exception("Field with key \""+key+"\" is already exist.");
            }
            _fields[key] = field;
            return _fields[key];
        }
    }
}
