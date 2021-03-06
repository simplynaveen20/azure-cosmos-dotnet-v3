﻿//-----------------------------------------------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//----------------------------------------------------------------------------------------------------------------------------------------
namespace Microsoft.Azure.Cosmos.Sql
{
    internal abstract class SqlSelectSpec : SqlObject
    {
        protected SqlSelectSpec(SqlObjectKind kind)
            : base(kind)
        { }
    }
}
