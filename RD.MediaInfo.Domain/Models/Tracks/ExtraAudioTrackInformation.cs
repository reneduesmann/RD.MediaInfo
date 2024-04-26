namespace RD.MediaInfo.Domain.Models.Tracks;

public class ExtraAudioTrackInformation
{
    [JsonPropertyName("bsid")]
    public int Bsid { get; set; }
    
    [JsonPropertyName("dialnorm")]
    public int Dialnorm { get; set; }
    
    [JsonPropertyName("dialnorm_String")]
    public string? DialnormString { get; set; }
    
    [JsonPropertyName("dsurmod")]
    public int Dsurmod { get; set; }
    
    [JsonPropertyName("acmod")]
    public int Acmod { get; set; }
    
    [JsonPropertyName("lfeon")]
    public int Lfeon { get; set; }
    
    [JsonPropertyName("dialnorm_Average")]
    public int DialnormAverage { get; set; }
    
    [JsonPropertyName("dialnorm_Average_String")]
    public string? DialnormAverageString { get; set; }
    
    [JsonPropertyName("dialnorm_Minimum")]
    public int DialnormMinimum { get; set; }
    
    [JsonPropertyName("dialnorm_Minimum_String")]
    public string? DialnormMinimumString { get; set; }
    
    [JsonPropertyName("dialnorm_Maximum")]
    public int DialnormMaximum { get; set; }
    
    [JsonPropertyName("dialnorm_Maximum_String")]
    public string? DialnormMaximumString { get; set; }
    
    [JsonPropertyName("dialnorm_Count")]
    public int DialnormCount { get; set; }
    
    [JsonPropertyName("compr")]
    public double Compr { get; set; }
    
    [JsonPropertyName("compr_String")]
    public string? ComprString { get; set; }
    
    [JsonPropertyName("dynrng")]
    public double Dynrng { get; set; }
    
    [JsonPropertyName("dynrng_String")]
    public string? DynrngString { get; set; }
    
    [JsonPropertyName("cmixlev")]
    public double Cmixlev { get; set; }
    
    [JsonPropertyName("cmixlev_String")]
    public string? CmixlevString { get; set; }
    
    [JsonPropertyName("surmixlev")]
    public double Surmixlev { get; set; }
    
    [JsonPropertyName("surmixlev_String")]
    public string? SurmixlevString { get; set; }
    
    [JsonPropertyName("ltrtcmixlev")]
    public double Ltrtcmixlev { get; set; }
    
    [JsonPropertyName("ltrtcmixlev_String")]
    public string? LtrtcmixlevString { get; set; }
    
    [JsonPropertyName("ltrtsurmixlev")]
    public double Ltrtsurmixlev { get; set; }
    
    [JsonPropertyName("ltrtsurmixlev_String")]
    public string? LtrtsurmixlevString { get; set; }
    
    [JsonPropertyName("lorocmixlev")]
    public double Lorocmixlev { get; set; }
    
    [JsonPropertyName("lorocmixlev_String")]
    public string? LorocmixlevString { get; set; }
    
    [JsonPropertyName("lorosurmixlev")]
    public double Lorosurmixlev { get; set; }
    
    [JsonPropertyName("lorosurmixlev_String")]
    public string? LorosurmixlevString { get; set; }
    
    [JsonPropertyName("compr_Average")]
    public double ComprAverage { get; set; }
    
    [JsonPropertyName("compr_Average_String")]
    public string? ComprAverageString { get; set; }
    
    [JsonPropertyName("compr_Minimum")]
    public double ComprMinimum { get; set; }
    
    [JsonPropertyName("compr_Minimum_String")]
    public string? ComprMinimumString { get; set; }
    
    [JsonPropertyName("compr_Maximum")]
    public double ComprMaximum { get; set; }
    
    [JsonPropertyName("compr_Maximum_String")]
    public string? ComprMaximumString { get; set; }
    
    [JsonPropertyName("compr_Count")]
    public int ComprCount { get; set; }
    
    [JsonPropertyName("dynrng_Average")]
    public double DynrngAverage { get; set; }
    
    [JsonPropertyName("dynrng_Average_String")]
    public string? DynrngAverageString { get; set; }
    
    [JsonPropertyName("dynrng_Minimum")]
    public double DynrngMinimum { get; set; }
    
    [JsonPropertyName("dynrng_Minimum_String")]
    public string? DynrngMinimumString { get; set; }
    
    [JsonPropertyName("dynrng_Maximum")]
    public double DynrngMaximum { get; set; }
    
    [JsonPropertyName("dynrng_Maximum_String")]
    public string? DynrngMaximumString { get; set; }
    
    [JsonPropertyName("dynrng_Count")]
    public int DynrngCount { get; set; }
}
