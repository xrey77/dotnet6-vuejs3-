using dotnet6_vuejs3.Entities;
using dotnet6_vuejs3.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace dotnet6_vuejs3.Services;

public class IUserService {
    private readonly IMongoCollection<Users> _usersCollection = null!;
    
    public IUserService(IOptions<DbSettings> _dbSettings) 
    {
        var mongoClient = new MongoClient(_dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(_dbSettings.Value.DatabaseName);        
    }   

   public async Task<List<Users>> GetAsync() => await _usersCollection.Find(_ => true).ToListAsync();

    public async Task<Users?> GetAsync(string id) => await _usersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Users newUser) => await _usersCollection.InsertOneAsync(newUser);

    public async Task UpdateAsync(string id, Users updatedUser) => await _usersCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);

    public async Task RemoveAsync(string id) => await _usersCollection.DeleteOneAsync(x => x.Id == id);
}