// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;

namespace Microsoft.Data.Entity.Metadata
{
    public interface IEntityType : IAnnotatable
    {
        IModel Model { get; }

        string Name { get; }
        string SimpleName { get; }

        bool IsAbstract { get; }
        bool UseEagerSnapshots { get; }
        bool HasDerivedTypes { get; }

        [CanBeNull]
        IEntityType BaseType { get; }

        [CanBeNull]
        Type Type { get; }

        [CanBeNull]
        IKey TryGetPrimaryKey();

        IKey GetPrimaryKey();

        [CanBeNull]
        IProperty TryGetProperty([NotNull] string name);

        [NotNull]
        IProperty GetProperty([NotNull] string name);

        [CanBeNull]
        INavigation TryGetNavigation([NotNull] string name);

        [NotNull]
        INavigation GetNavigation([NotNull] string name);

        IEnumerable<IProperty> GetProperties();
        IEnumerable<IForeignKey> GetForeignKeys();
        IEnumerable<INavigation> GetNavigations();
        IEnumerable<IIndex> GetIndexes();
        IEnumerable<IKey> GetKeys();

        IEnumerable<IEntityType> GetDerivedTypes();
        IEnumerable<IEntityType> GetConcreteTypesInHierarchy();
    }
}
