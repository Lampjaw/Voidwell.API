﻿using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Voidwell.API.Clients
{
    public interface IDaybreakGamesClient : IDisposable
    {
        Task<JToken> GetMonitorState();
        Task<JToken> GetOnlinePlayers(int worldId);
        Task<JToken> GetZoneOwnership(int worldId, int zoneId);
        Task<JToken> GetZoneMap(int zoneId);
        Task<JToken> GetGrades();
        Task<JToken> GetPlanetside2News();
        Task<JToken> GetPlanetside2Updates();
        Task<JToken> Search(string query);
        Task<JToken> GetAlerts(int pageNumber, int? worldId);
        Task<JToken> GetAlert(string worldId, string alertId);
        Task<JToken> GetCharacter(string characterId);
        Task<JToken> GetCharacterSessions(string characterId);
        Task<JToken> GetCharacterSession(string characterId, string sessionId);
        Task<JToken> GetWeaponLeaderboard(string weaponItemId);
        Task<JToken> GetWorldTerritory(string worldId, string zoneId);
        Task<JToken> GetWorldPopulation(string worldId, string zoneId);
        Task<JToken> GetOutfit(string outfitId);
        Task<JToken> GetOutfitMembers(string outfitId);
        Task<JToken> GetAllPlayableClasses();
        Task<JToken> GetAllVehicles();
        Task<JToken> GetWeaponInfo(string weaponItemId);
        Task<JToken> GetServiceStates();
        Task<JToken> GetServiceState(string service);
        Task<JToken> EnableService(string service);
        Task<JToken> DisableService(string service);
        Task<JToken> GetLastOnlinePSBAccounts();
        Task<JToken> SetupWorldZoneStates(int worldId);
        Task<JToken> GetCharacterStatsByName(string characterName);
        Task<JToken> GetCharacterWeaponStatsByName(string characterName, string weaponName);
        Task<JToken> GetOutfitStatsByAlias(string outfitAlias);
        Task<JToken> GetOracleCategory(string categoryId);
        Task<JToken> GetOracleStats(string statId, IEnumerable<string> weaponIds);
        Task<JToken> GetPlayerRankings();
    }
}
