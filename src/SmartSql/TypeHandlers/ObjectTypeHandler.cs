﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartSql.Data;

namespace SmartSql.TypeHandlers
{
    public class ObjectTypeHandler : AbstractTypeHandler<Object, Object>
    {
        public override object GetValue(DataReaderWrapper dataReader, int columnIndex, Type targetType)
        {
            return dataReader.GetValue(columnIndex);
        }
    }
}
