using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Bludata.Teste.CSharp.Domain.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum State
    {
        [EnumMember(Value = "Acre")]
        AC = 1,
        [EnumMember(Value = "Alagoas")]
        AL = 2,
        [EnumMember(Value = "Amapá")]
        AP = 3,
        [EnumMember(Value = "Amazonas")]
        AM = 4,
        [EnumMember(Value = "Bahia")]
        BA = 5,
        [EnumMember(Value = "Ceará")]
        CE = 6,
        [EnumMember(Value = "Distrito Federal")]
        DF = 7,
        [EnumMember(Value = "Espírito Santo")]
        ES = 8,
        [EnumMember(Value = "Goiás")]
        GO = 9,
        [EnumMember(Value = "Maranhão")]
        MA = 10,
        [EnumMember(Value = "Mato Grosso")]
        MT = 11,
        [EnumMember(Value = "Mato Grosso do Sul")]
        MS = 12,
        [EnumMember(Value = "Minas Gerais")]
        MG = 13,
        [EnumMember(Value = "Pará")]
        PA = 14,
        [EnumMember(Value = "Paraíba")]
        PB = 15,
        [EnumMember(Value = "Paraná")]
        PR = 0,
        [EnumMember(Value = "Pernambuco")]
        PE = 17,
        [EnumMember(Value = "Piauí")]
        PI = 18,
        [EnumMember(Value = "Rio de Janeiro")]
        RJ = 19,
        [EnumMember(Value = "Rio Grande do Norte")]
        RN = 20,
        [EnumMember(Value = "Rio Grande do Sul")]
        RS = 21,
        [EnumMember(Value = "Rondônia")]
        RO = 22,
        [EnumMember(Value = "Roraima")]
        RR = 23,
        [EnumMember(Value = "Santa Catarina")]
        SC = 24,
        [EnumMember(Value = "São Paulo")]
        SP = 25,
        [EnumMember(Value = "Sergipe")]
        SE = 26,
        [EnumMember(Value = "Tocantins")]
        TO = 27
    }
}
