﻿using MongoDB.Driver;
using MongoDbGenericRepository.DataAccess.Update;
using MongoDbGenericRepository.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MongoDbGenericRepository
{
    public interface IBaseMongoRepository_Update : IBaseMongoRepository_Update<Guid>
    {
        /// <summary>
        /// Asynchronously Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        Task<bool> UpdateOneAsync<TDocument, TKey>(TDocument modifiedDocument)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        bool UpdateOne<TDocument, TKey>(TDocument modifiedDocument)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        Task<bool> UpdateOneAsync<TDocument, TKey>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        bool UpdateOne<TDocument, TKey>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value..
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        bool UpdateOne<TDocument, TKey, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        Task<bool> UpdateOneAsync<TDocument, TKey, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        Task<bool> UpdateOneAsync<TDocument, TKey, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        bool UpdateOne<TDocument, TKey, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        Task<bool> UpdateOneAsync<TDocument, TKey, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        bool UpdateOne<TDocument, TKey, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>;
    }
    /// <summary>
    /// The base Repository, it is meant to be inherited from by your custom custom MongoRepository implementation.
    /// Its constructor must be given a connection string and a database name.
    /// </summary>
    public abstract partial class BaseMongoRepository : IBaseMongoRepository_Update
    {
        private MongoDbUpdater _mongoDbUpdater;
        protected MongoDbUpdater MongoDbUpdater
        {
            get
            {
                if (_mongoDbUpdater != null) { return _mongoDbUpdater; }

                lock (_initLock)
                {
                    if (_mongoDbUpdater == null)
                    {
                        _mongoDbUpdater = new MongoDbUpdater(MongoDbContext);
                    }
                }

                return _mongoDbUpdater;
            }
        }

        #region Update

        /// <summary>
        /// Asynchronously Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument>(TDocument modifiedDocument) where TDocument : IDocument<Guid>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, Guid>(modifiedDocument);
        }

        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        public virtual bool UpdateOne<TDocument>(TDocument modifiedDocument) where TDocument : IDocument<Guid>
        {
            return MongoDbUpdater.UpdateOne<TDocument, Guid>(modifiedDocument);
        }

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<Guid>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, Guid>(documentToModify, update);

        }

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        public virtual bool UpdateOne<TDocument>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<Guid>
        {
            return MongoDbUpdater.UpdateOne<TDocument, Guid>(documentToModify, update);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        public virtual bool UpdateOne<TDocument, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<Guid>
        {
            return MongoDbUpdater.UpdateOne<TDocument, Guid, TField>(documentToModify, field, value);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<Guid>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, Guid, TField>(documentToModify, field, value);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        public virtual bool UpdateOne<TDocument, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<Guid>
        {
            return MongoDbUpdater.UpdateOne<TDocument, Guid, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        public virtual bool UpdateOne<TDocument, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<Guid>
        {
            return MongoDbUpdater.UpdateOne<TDocument, Guid, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<Guid>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, Guid, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<Guid>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, Guid, TField>(filter, field, value, partitionKey);
        }

        #endregion Update

        #region Update TKey

        /// <summary>
        /// Asynchronously Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TKey>(TDocument modifiedDocument)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, TKey>(modifiedDocument);
        }

        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        public virtual bool UpdateOne<TDocument, TKey>(TDocument modifiedDocument)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return MongoDbUpdater.UpdateOne<TDocument, TKey>(modifiedDocument);
        }

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TKey>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, TKey>(documentToModify, update);
        }

        /// <summary>
        /// Takes a document you want to modify and applies the update you have defined in MongoDb.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="update">The update definition for the document.</param>
        public virtual bool UpdateOne<TDocument, TKey>(TDocument documentToModify, UpdateDefinition<TDocument> update)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return MongoDbUpdater.UpdateOne<TDocument, TKey>(documentToModify, update);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        public virtual bool UpdateOne<TDocument, TKey, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return MongoDbUpdater.UpdateOne<TDocument, TKey, TField>(documentToModify, field, value);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="documentToModify">The document you want to modify.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TKey, TField>(TDocument documentToModify, Expression<Func<TDocument, TField>> field, TField value)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, TKey, TField>(documentToModify, field, value);
        }

        /// <summary>
        /// Updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        public virtual bool UpdateOne<TDocument, TKey, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return MongoDbUpdater.UpdateOne<TDocument, TKey, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        public virtual bool UpdateOne<TDocument, TKey, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return MongoDbUpdater.UpdateOne<TDocument, TKey, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// Updates the property field with the given value update a property field in entities.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The value of the partition key.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TKey, TField>(FilterDefinition<TDocument> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, TKey, TField>(filter, field, value, partitionKey);
        }

        /// <summary>
        /// For the entity selected by the filter, updates the property field with the given value.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <typeparam name="TKey">The type of the primary key for a Document.</typeparam>
        /// <typeparam name="TField">The type of the field.</typeparam>
        /// <param name="filter">The document filter.</param>
        /// <param name="field">The field selector.</param>
        /// <param name="value">The new value of the property field.</param>
        /// <param name="partitionKey">The partition key for the document.</param>
        public virtual async Task<bool> UpdateOneAsync<TDocument, TKey, TField>(Expression<Func<TDocument, bool>> filter, Expression<Func<TDocument, TField>> field, TField value, string partitionKey = null)
            where TDocument : IDocument<TKey>
            where TKey : IEquatable<TKey>
        {
            return await MongoDbUpdater.UpdateOneAsync<TDocument, TKey, TField>(Builders<TDocument>.Filter.Where(filter), field, value, partitionKey);
        }

        #endregion Update
    }

}
