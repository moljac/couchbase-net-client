﻿using Couchbase.Diagnostics;
using Couchbase.KeyValue;
using Couchbase.Management.Collections;
using Couchbase.Management.Views;
using Couchbase.Protostellar.Query.V1;
using Couchbase.Stellar.KeyValue;
using Couchbase.Stellar.Management.Collections;
using Couchbase.Stellar.Util;
using Couchbase.Views;

namespace Couchbase.Stellar;

internal class StellarBucket : IBucket
{
    private readonly StellarCluster _stellarCluster;
    private readonly QueryService.QueryServiceClient _queryClient;
    private readonly StellarCollectionManager _collectionManager;

    internal StellarBucket(string name, StellarCluster stellarCluster, QueryService.QueryServiceClient queryClient)
    {
        Name = name;
        _stellarCluster = stellarCluster;
        _queryClient = queryClient;
        _collectionManager = new StellarCollectionManager(_stellarCluster, name);
    }

    public bool SupportsCollections => true;

    public string Name { get; }


    public ICluster Cluster => _stellarCluster;

    public IViewIndexManager ViewIndexes => throw new UnsupportedInProtostellarException("View Indexes");

    public ICouchbaseCollectionManager Collections => _collectionManager;

    public ICouchbaseCollection Collection(string collectionName) => DefaultScope().Collection(collectionName);

    public ValueTask<ICouchbaseCollection> CollectionAsync(string collectionName) => ValueTask.FromResult(Collection(collectionName));

    public ICouchbaseCollection DefaultCollection() => DefaultScope().Collection("_default");

    public ValueTask<ICouchbaseCollection> DefaultCollectionAsync() => ValueTask.FromResult(DefaultCollection());

    public IScope DefaultScope() => Scope("_default");

    public ValueTask<IScope> DefaultScopeAsync() => ValueTask.FromResult(DefaultScope());

    public void Dispose()
    {
        throw new UnsupportedInProtostellarException("Bucket Dispose");
    }

    public ValueTask DisposeAsync()
    {
        throw new UnsupportedInProtostellarException("Bucket Async Dispose");
    }

    public Task<IPingReport> PingAsync(PingOptions? options = null)
    {
        throw new UnsupportedInProtostellarException("Ping Bucket");
    }

    public IScope Scope(string scopeName) => new StellarScope(scopeName, this, _stellarCluster, _queryClient);

    public ValueTask<IScope> ScopeAsync(string scopeName) => ValueTask.FromResult(Scope(scopeName));

    public Task<IViewResult<TKey, TValue>> ViewQueryAsync<TKey, TValue>(string designDocument, string viewName, ViewOptions? options = null)
    {
        throw new UnsupportedInProtostellarException("Bucket View Queries");
    }

    public Task WaitUntilReadyAsync(TimeSpan timeout, WaitUntilReadyOptions? options = null)
    {
        throw new UnsupportedInProtostellarException("Bucket WaitUntilReady");
    }
}