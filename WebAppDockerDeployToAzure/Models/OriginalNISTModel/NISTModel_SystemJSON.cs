
namespace WebAppDockerDeployToAzure.Models.OriginalNISTModel
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class NISTModel
    {
        [JsonPropertyName("@type")]
        public CoordinateType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AdditionalInfo")]
        public List<VriAdditionalInfo> AdditionalInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("BallotRequest")]
        public VriBallotRequest BallotRequest { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Form")]
        public VriRequestForm? Form { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("GeneratedDate")]
        public DateTimeOffset? GeneratedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Issuer")]
        public string Issuer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherForm")]
        public string OtherForm { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherRequestMethod")]
        public string OtherRequestMethod { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RequestHelper")]
        public List<VriRequestHelper> RequestHelper { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RequestMethod")]
        public VriRequestMethod? RequestMethod { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RequestProxy")]
        public VriRequestProxy RequestProxy { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SelectedLanguage")]
        public string SelectedLanguage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Subject")]
        public VriVoter Subject { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("TransactionId")]
        public string TransactionId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Type")]
        public List<VriVoterRequestType> CoordinateType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VendorApplicationId")]
        public string VendorApplicationId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AdditionalDetails")]
        public List<string> AdditionalDetails { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Error")]
        public List<VriError> Error { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Action")]
        public List<VriSuccessAction> Action { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("District")]
        public List<VriReportingUnit> District { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("EffectiveDate")]
        public DateTimeOffset? EffectiveDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ElectionAdministration")]
        public VriElectionAdministration ElectionAdministration { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Locality")]
        public List<VriReportingUnit> Locality { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PollingPlace")]
        public VriReportingUnit PollingPlace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VoterRecord")]
        public List<VriVoterRecord> VoterRecord { get; set; }
    }

    public partial class VriAdditionalInfo
    {
        [JsonPropertyName("@type")]
        public AdditionalInfoType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FileValue")]
        public Vri FileValue { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StringValue")]
        public string StringValue { get; set; }
    }

    public partial class Vri
    {
        [JsonPropertyName("@type")]
        public PurpleType Type { get; set; }

        [JsonPropertyName("Data")]
        public string Data { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FileName")]
        public string FileName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MimeType")]
        public string MimeType { get; set; }
    }

    public partial class VriBallotRequest
    {
        [JsonPropertyName("@type")]
        public BallotRequestType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("BallotReceiptPreference")]
        public List<VriBallotReceiptMethod> BallotReceiptPreference { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Election")]
        public VriElection Election { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MailForwardingAddress")]
        public VriAddress MailForwardingAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("EndDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StartDate")]
        public DateTimeOffset? StartDate { get; set; }
    }

    public partial class VriElection
    {
        [JsonPropertyName("@type")]
        public ElectionType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("EndDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ExternalIdentifier")]
        public List<VriExternalIdentifier> ExternalIdentifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTimeOffset StartDate { get; set; }
    }

    public partial class VriExternalIdentifier
    {
        [JsonPropertyName("@type")]
        public ExternalIdentifierType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriIdentifierType VriExternalIdentifierType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class VriAddress
    {
        [JsonPropertyName("@type")]
        public VriAddressType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("action")]
        public AddrTypeActionType? Action { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressAnomalyStatus")]
        public string AddressAnomalyStatus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressAuthority")]
        public string AddressAuthority { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressClassification")]
        public AddrTypeAddressClassificationType? AddressClassification { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressCoordinateReferenceSystem")]
        public AddrTypeAddressCoordinateReferenceSystemType AddressCoordinateReferenceSystem { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressElevation")]
        public double? AddressElevation { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressEndDate")]
        public DateTimeOffset? AddressEndDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressFeatureType")]
        public List<string> AddressFeatureType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressId")]
        public string AddressId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressLatitude")]
        public double? AddressLatitude { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressLifecycleStatus")]
        public AddrTypeAddressLifecycleStatusType? AddressLifecycleStatus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressLongitude")]
        public double? AddressLongitude { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressParcelIdentifier")]
        public List<string> AddressParcelIdentifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressParcelIdentifierSource")]
        public List<string> AddressParcelIdentifierSource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressRangeDirectionality")]
        public List<AddrTypeAddressRangeDirectionalityType> AddressRangeDirectionality { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressRangeParity")]
        public List<AddrTypeAddressRangeParityType> AddressRangeParity { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressRangeSpan")]
        public List<AddrTypeAddressRangeSpanType> AddressRangeSpan { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressRangeType")]
        public List<AddrTypeAddressRangeTypeType> AddressRangeType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressReferenceSystemAuthority")]
        public string AddressReferenceSystemAuthority { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressReferenceSystemId")]
        public long? AddressReferenceSystemId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressSideOfStreet")]
        public AddrTypeAddressSideOfStreetType? AddressSideOfStreet { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressStartDate")]
        public DateTimeOffset? AddressStartDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressTransportationFeatureID")]
        public string AddressTransportationFeatureId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressTransportationFeatureType")]
        public string AddressTransportationFeatureType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressTransportationSystemAuthority")]
        public string AddressTransportationSystemAuthority { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressTransportationSystemName")]
        public string AddressTransportationSystemName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressXCoordinate")]
        public double? AddressXCoordinate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressYCoordinate")]
        public double? AddressYCoordinate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressZLevel")]
        public string AddressZLevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteAddressNumber")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteLandmarkName")]
        public AddrTypeCompleteLandmarkNameType CompleteLandmarkName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompletePlaceName1")]
        public AddrTypeCompletePlaceNameType CompletePlaceName1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompletePlaceName2")]
        public AddrTypeCompletePlaceNameType CompletePlaceName2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteSubaddress")]
        public AddrTypeCompleteSubaddressType CompleteSubaddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CountryName")]
        public string CountryName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("DataSetID")]
        public string DataSetId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LocationDescription")]
        public string LocationDescription { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MailableAddress")]
        public AddrTypeMailableAddressType? MailableAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OfficialStatus")]
        public AddrTypeOfficialStatusType? OfficialStatus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PlaceStateZip")]
        public List<string> PlaceStateZip { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RelatedAddressId")]
        public List<string> RelatedAddressId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RelatedTransportationFeatureID")]
        public List<string> RelatedTransportationFeatureId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StateName")]
        public string StateName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("USNationalGridCoordinate")]
        public string UsNationalGridCoordinate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ZipPlus4")]
        public string ZipPlus4 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteAddressNumber1")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteAddressNumber2")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteAddressNumber3")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteAddressNumber4")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber4 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteStreetName")]
        public AddrTypeCompleteStreetNameType CompleteStreetName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SeparatorElement1")]
        public string SeparatorElement1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SeparatorElement2")]
        public string SeparatorElement2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompletePlaceName")]
        public AddrTypeCompletePlaceNameType CompletePlaceName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("GeneralAddress")]
        public string GeneralAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("USPSGeneralDeliveryPoint")]
        public string UspsGeneralDeliveryPoint { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteStreetName1")]
        public AddrTypeCompleteStreetNameType CompleteStreetName1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompleteStreetName2")]
        public AddrTypeCompleteStreetNameType CompleteStreetName2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CornerOf")]
        public string CornerOf { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SeparatorElement")]
        public string SeparatorElement { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("USPSBox")]
        public AddrTypeUspsBoxType UspsBox { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("USPSAddress")]
        public AddrTypeUspsAddressType UspsAddress { get; set; }
    }

    public partial class AddrTypeAddressCoordinateReferenceSystemType
    {
        [JsonPropertyName("@type")]
        public AddressCoordinateReferenceSystemType Type { get; set; }

        [JsonPropertyName("AddressCoordinateReferenceSystemAuthority")]
        public string AddressCoordinateReferenceSystemAuthority { get; set; }

        [JsonPropertyName("AddressCoordinateReferenceSystemID")]
        public long AddressCoordinateReferenceSystemId { get; set; }
    }

    public partial class AddrTypeCompleteAddressNumberType
    {
        [JsonPropertyName("@type")]
        public CompleteAddressNumberType Type { get; set; }

        [JsonPropertyName("AddressNumber")]
        public string AddressNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressNumberParity")]
        public AddrTypeAddressNumberParityType? AddressNumberParity { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressNumberPrefix")]
        public AddrTypeAddressNumberPrefixType AddressNumberPrefix { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AddressNumberSuffix")]
        public AddrTypeAddressNumberSuffixType AddressNumberSuffix { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AttachedElement")]
        public AddrTypeAttachedElementType? AttachedElement { get; set; }
    }

    public partial class AddrTypeAddressNumberPrefixType
    {
        [JsonPropertyName("@type")]
        public AddressNumberPrefixType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeAddressNumberSuffixType
    {
        [JsonPropertyName("@type")]
        public AddressNumberSuffixType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteLandmarkNameType
    {
        [JsonPropertyName("@type")]
        public CompleteLandmarkNameType Type { get; set; }

        [JsonPropertyName("LandmarkName")]
        public List<AddrTypeLandmarkNameType> LandmarkName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }
    }

    public partial class AddrTypeLandmarkNameType
    {
        [JsonPropertyName("@type")]
        public LandmarkNameType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ElementSequenceNumber")]
        public long? ElementSequenceNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("GNISFeatureID")]
        public long? GnisFeatureId { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompletePlaceNameType
    {
        [JsonPropertyName("@type")]
        public CompletePlaceNameType Type { get; set; }

        [JsonPropertyName("PlaceName")]
        public List<AddrTypePlaceNameType> PlaceName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }
    }

    public partial class AddrTypePlaceNameType
    {
        [JsonPropertyName("@type")]
        public PlaceNameType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ElementSequenceNumber")]
        public long? ElementSequenceNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("GNISFeatureID")]
        public long? GnisFeatureId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PlaceNameType")]
        public AddrTypePlaceNameTypeType? PlaceNameType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteStreetNameType
    {
        [JsonPropertyName("@type")]
        public CompleteStreetNameType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AttachedElement")]
        public AddrTypeAttachedElementType? AttachedElement { get; set; }

        [JsonPropertyName("StreetName")]
        public string StreetName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePostDirectional")]
        public AddrTypeStreetNamePreDirectionalType StreetNamePostDirectional { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePostModifier")]
        public AddrTypeStreetNamePreModifierType StreetNamePostModifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePostType")]
        public AddrTypeStreetNamePreTypeType StreetNamePostType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePreDirectional")]
        public AddrTypeStreetNamePreDirectionalType StreetNamePreDirectional { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePreModifier")]
        public AddrTypeStreetNamePreModifierType StreetNamePreModifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StreetNamePreType")]
        public AddrTypeStreetNamePreTypeType StreetNamePreType { get; set; }
    }

    public partial class AddrTypeStreetNamePreDirectionalType
    {
        [JsonPropertyName("@type")]
        public StreetNamePostDirectionalType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeStreetNamePreModifierType
    {
        [JsonPropertyName("@type")]
        public StreetNamePostModifierType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeStreetNamePreTypeType
    {
        [JsonPropertyName("@type")]
        public StreetNamePostTypeType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteSubaddressType
    {
        [JsonPropertyName("@type")]
        public CompleteSubaddressType Type { get; set; }

        [JsonPropertyName("SubaddressElement")]
        public List<AddrTypeSubaddressElementType> SubaddressElement { get; set; }
    }

    public partial class AddrTypeSubaddressElementType
    {
        [JsonPropertyName("@type")]
        public SubaddressElementType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ElementSequenceNumber")]
        public long? ElementSequenceNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("GNISFeatureID")]
        public long? GnisFeatureId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SubaddressComponentOrder")]
        public AddrTypeSubaddressComponentOrderType? SubaddressComponentOrder { get; set; }

        [JsonPropertyName("SubaddressIdentifier")]
        public string SubaddressIdentifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SubaddressType")]
        public string SubaddressType { get; set; }
    }

    public partial class AddrTypeUspsAddressType
    {
        [JsonPropertyName("@type")]
        public UspsAddressType Type { get; set; }

        [JsonPropertyName("USPSBox")]
        public AddrTypeUspsBoxType UspsBox { get; set; }

        [JsonPropertyName("USPSRoute")]
        public AddrTypeUspsRouteType UspsRoute { get; set; }
    }

    public partial class AddrTypeUspsBoxType
    {
        [JsonPropertyName("@type")]
        public UspsBoxType Type { get; set; }

        [JsonPropertyName("USPSBoxId")]
        public string UspsBoxId { get; set; }

        [JsonPropertyName("USPSBoxType")]
        public string UspsBoxType { get; set; }
    }

    public partial class AddrTypeUspsRouteType
    {
        [JsonPropertyName("@type")]
        public UspsRouteType Type { get; set; }

        [JsonPropertyName("USPSBoxGroupId")]
        public string UspsBoxGroupId { get; set; }

        [JsonPropertyName("USPSBoxGroupType")]
        public string UspsBoxGroupType { get; set; }
    }

    public partial class VriReportingUnit
    {
        [JsonPropertyName("@type")]
        public PollingPlaceType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ExternalIdentifier")]
        public List<VriExternalIdentifier> ExternalIdentifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("IsDistricted")]
        public bool? IsDistricted { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Location")]
        public VriLocation Location { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriReportingUnitType VriReportingUnitType { get; set; }
    }

    public partial class VriLocation
    {
        [JsonPropertyName("@type")]
        public LocationType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Address")]
        public VriAddress Address { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Directions")]
        public string Directions { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LatLng")]
        public VriLatLng LatLng { get; set; }
    }

    public partial class VriLatLng
    {
        [JsonPropertyName("@type")]
        public LatLngType Type { get; set; }

        [JsonPropertyName("Latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("Longitude")]
        public double Longitude { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Source")]
        public string Source { get; set; }
    }

    public partial class VriElectionAdministration
    {
        [JsonPropertyName("@type")]
        public ElectionAdministrationType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ContactMethod")]
        public List<VriContactMethod> ContactMethod { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Location")]
        public VriLocation Location { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Uri")]
        public List<Uri> Uri { get; set; }
    }

    public partial class VriContactMethod
    {
        [JsonPropertyName("@type")]
        public ContactMethodType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriContactMethodType VriContactMethodType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Capability")]
        public List<VriPhoneCapability> Capability { get; set; }
    }

    public partial class VriError
    {
        [JsonPropertyName("@type")]
        public ErrorType Type { get; set; }

        [JsonPropertyName("Name")]
        public VriRequestError Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherError")]
        public string OtherError { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Ref")]
        public string Ref { get; set; }
    }

    public partial class VriRequestHelper
    {
        [JsonPropertyName("@type")]
        public RequestHelperType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Address")]
        public VriAddress Address { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public VriName Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Phone")]
        public VriPhoneContactMethod Phone { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Signature")]
        public VriSignature Signature { get; set; }

        [JsonPropertyName("Type")]
        public VriVoterHelperType VriRequestHelperType { get; set; }
    }

    public partial class VriName
    {
        [JsonPropertyName("@type")]
        public NameType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FullName")]
        public string FullName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MiddleName")]
        public List<string> MiddleName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prefix")]
        public string Prefix { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Suffix")]
        public string Suffix { get; set; }
    }

    public partial class VriPhoneContactMethod
    {
        [JsonPropertyName("@type")]
        public PhoneType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Capability")]
        public List<VriPhoneCapability> Capability { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriContactMethodType VriPhoneContactMethodType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class VriSignature
    {
        [JsonPropertyName("@type")]
        public PreviousSignatureType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Date")]
        public DateTimeOffset? Date { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FileValue")]
        public VriImage FileValue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherSource")]
        public string OtherSource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Source")]
        public VriSignatureSource? Source { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Type")]
        public VriSignatureType? VriSignatureType { get; set; }
    }

    public partial class VriImage
    {
        [JsonPropertyName("@type")]
        public FluffyType Type { get; set; }

        [JsonPropertyName("Data")]
        public string Data { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FileName")]
        public string FileName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MimeType")]
        public string MimeType { get; set; }
    }

    public partial class VriRequestProxy
    {
        [JsonPropertyName("@type")]
        public RequestProxyType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Address")]
        public VriAddress Address { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OriginTransactionId")]
        public string OriginTransactionId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Phone")]
        public VriPhoneContactMethod Phone { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("TimeStamp")]
        public DateTimeOffset? TimeStamp { get; set; }

        [JsonPropertyName("Type")]
        public VriRequestProxyType VriRequestProxyType { get; set; }
    }

    public partial class VriVoter
    {
        [JsonPropertyName("@type")]
        public SubjectType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ContactMethod")]
        public List<VriContactMethod> ContactMethod { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("DateOfBirth")]
        public DateTimeOffset? DateOfBirth { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Ethnicity")]
        public string Ethnicity { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("MailingAddress")]
        public VriAddress MailingAddress { get; set; }

        [JsonPropertyName("Name")]
        public VriName Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Party")]
        public VriParty Party { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PreviousName")]
        public VriName PreviousName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PreviousResidenceAddress")]
        public VriAddress PreviousResidenceAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PreviousSignature")]
        public VriSignature PreviousSignature { get; set; }

        [JsonPropertyName("ResidenceAddress")]
        public VriAddress ResidenceAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ResidenceAddressIsMailingAddress")]
        public bool? ResidenceAddressIsMailingAddress { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Signature")]
        public VriSignature Signature { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VoterClassification")]
        public List<VriVoterClassification> VoterClassification { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VoterId")]
        public List<VriVoterId> VoterId { get; set; }
    }

    public partial class VriParty
    {
        [JsonPropertyName("@type")]
        public PartyType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Abbreviation")]
        public string Abbreviation { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ExternalIdentifier")]
        public List<VriExternalIdentifier> ExternalIdentifier { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }

    public partial class VriVoterClassification
    {
        [JsonPropertyName("@type")]
        public VoterClassificationType Type { get; set; }

        [JsonPropertyName("Assertion")]
        public VriAssertionValue Assertion { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherAssertion")]
        public string OtherAssertion { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriVoterClassificationType VriVoterClassificationType { get; set; }
    }

    public partial class VriVoterId
    {
        [JsonPropertyName("@type")]
        public VoterIdType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AttestNoSuchId")]
        public bool? AttestNoSuchId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("DateOfIssuance")]
        public DateTimeOffset? DateOfIssuance { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FileValue")]
        public Vri FileValue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StringValue")]
        public string StringValue { get; set; }

        [JsonPropertyName("Type")]
        public VriVoterIdType VriVoterIdType { get; set; }
    }

    public partial class VriVoterRecord
    {
        [JsonPropertyName("@type")]
        public VoterRecordType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("District")]
        public List<VriReportingUnit> District { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ElectionAdministration")]
        public VriElectionAdministration ElectionAdministration { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("HavaIdRequired")]
        public bool? HavaIdRequired { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Locality")]
        public List<VriReportingUnit> Locality { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OtherStatus")]
        public string OtherStatus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PollingLocation")]
        public VriReportingUnit PollingLocation { get; set; }

        [JsonPropertyName("Voter")]
        public VriVoter Voter { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VoterParticipation")]
        public List<VriVoterParticipation> VoterParticipation { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("VoterStatus")]
        public VriVoterStatus? VoterStatus { get; set; }
    }

    public partial class VriVoterParticipation
    {
        [JsonPropertyName("@type")]
        public VoterParticipationType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("BallotStyle")]
        public VriBallotStyle BallotStyle { get; set; }

        [JsonPropertyName("Election")]
        public VriElection Election { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PollingLocation")]
        public VriReportingUnit PollingLocation { get; set; }
    }

    public partial class VriBallotStyle
    {
        [JsonPropertyName("@type")]
        public BallotStyleType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ExternalIdentifier")]
        public List<VriExternalIdentifier> ExternalIdentifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ImageUri")]
        public List<Uri> ImageUri { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Party")]
        public List<VriParty> Party { get; set; }
    }

    public enum VriSuccessAction { AddressUpdated, NameUpdated, Other, RegistrationCancelled, RegistrationCreated, RegistrationUpdated, StatusUpdated };

    public enum PurpleType { VriFile, VriImage };

    public enum AdditionalInfoType { VriAdditionalInfo };

    public enum VriBallotReceiptMethod { Email, EmailOrOnline, Fax, Mail, Online };

    public enum ExternalIdentifierType { VriExternalIdentifier };

    public enum VriIdentifierType { Fips, LocalLevel, NationalLevel, OcdId, Other, StateLevel };

    public enum ElectionType { VriElection };

    public enum AddrTypeActionType { Add, Delete };

    public enum AddrTypeAddressClassificationType { CommunityAddress, FourNumberAddressRange, GeneralAddressClass, IntersectionAddress, LandmarkAddress, NumberedThoroughfareAddress, TwoNumberAddressRange, UnnumberedThoroughfareAddress, UspsGeneralDeliveryOffice, UspsPostalDeliveryBox, UspsPostalDeliveryRoute };

    public enum AddressCoordinateReferenceSystemType { AddrTypeAddressCoordinateReferenceSystemType };

    public enum AddrTypeAddressLifecycleStatusType { Active, Potential, Proposed, Retired };

    public enum AddrTypeAddressRangeDirectionalityType { Against, AgainstWith, Na, Null, Unknown, With, WithAgainst };

    public enum AddrTypeAddressRangeParityType { Both, Even, None, Odd, Unknown };

    public enum AddrTypeAddressRangeSpanType { EntireStreet, MultiSegment, PartialSegment, SingleSegment, Unknown };

    public enum AddrTypeAddressRangeTypeType { Actual, Potential, Unknown };

    public enum AddrTypeAddressSideOfStreetType { Both, Left, None, Right, Unknown };

    public enum AddrTypeAddressNumberParityType { Even, Odd };

    public enum AddressNumberPrefixType { AddrTypeAddressNumberPrefixType };

    public enum AddressNumberSuffixType { AddrTypeAddressNumberSuffixType };

    public enum AddrTypeAttachedElementType { Attached, NotAttached, Unknown };

    public enum CompleteAddressNumberType { AddrTypeCompleteAddressNumberType };

    public enum LandmarkNameType { AddrTypeLandmarkNameType };

    public enum CompleteLandmarkNameType { AddrTypeCompleteLandmarkNameType };

    public enum AddrTypePlaceNameTypeType { County, MunicipalJurisdiction, UspsCommunity };

    public enum PlaceNameType { AddrTypePlaceNameType };

    public enum CompletePlaceNameType { AddrTypeCompletePlaceNameType };

    public enum StreetNamePostDirectionalType { AddrTypeStreetNamePreDirectionalType };

    public enum StreetNamePostModifierType { AddrTypeStreetNamePreModifierType };

    public enum StreetNamePostTypeType { AddrTypeStreetNamePreTypeType };

    public enum CompleteStreetNameType { AddrTypeCompleteStreetNameType };

    public enum AddrTypeSubaddressComponentOrderType { The1, The2, The3 };

    public enum SubaddressElementType { AddrTypeSubaddressElementType };

    public enum CompleteSubaddressType { AddrTypeCompleteSubaddressType };

    public enum AddrTypeMailableAddressType { No, Unknown, Yes };

    public enum AddrTypeOfficialStatusType { AlternateNamesEstablishedByColloquialUseInACommunity, AlternateOrAlias, AlternatesEstablishedByAnAddressAuthority, Official, OfficialAlternateOrAlias, OfficialRenamingActionOfTheAddressAuthority, PostedOrVanityAddress, UnofficialAlternateNamesFrequentlyEncountered, UnofficialAlternateNamesInUseByAnAgencyOrEntity, UnofficialAlternateOrAlias, VerifiedInvalid };

    public enum VriAddressType { AddrCommunityAddressType, AddrFourNumberAddressRangeType, AddrGeneralAddressClassType, AddrIntersectionAddressType, AddrLandmarkAddressType, AddrNumberedThoroughfareAddressType, AddrTwoNumberAddressRangeType, AddrUnnumberedThoroughfareAddressType, AddrUspsGeneralDeliveryOfficeType, AddrUspsPostalDeliveryBoxType, AddrUspsPostalDeliveryRouteType };

    public enum UspsAddressType { AddrTypeUspsAddressType };

    public enum UspsBoxType { AddrTypeUspsBoxType };

    public enum UspsRouteType { AddrTypeUspsRouteType };

    public enum BallotRequestType { VriElectionBasedBallotRequest, VriPermanentBallotRequest, VriTemporalBallotRequest };

    public enum VriVoterRequestType { BallotRequest, Lookup, Other, Registration };

    public enum LatLngType { VriLatLng };

    public enum LocationType { VriLocation };

    public enum PollingPlaceType { VriReportingUnit };

    public enum VriReportingUnitType { BallotBatch, BallotStyleArea, Borough, City, CityCouncil, CombinedPrecinct, Congressional, County, CountyCouncil, DropBox, Judicial, Municipality, Other, PollingPlace, Precinct, School, Special, SplitPrecinct, State, StateHouse, StateSenate, Town, Township, Utility, Village, VoteCenter, Ward, Water };

    public enum VriPhoneCapability { Fax, Mms, Sms, Voice };

    public enum ContactMethodType { VriContactMethod, VriPhoneContactMethod };

    public enum VriContactMethodType { Email, Other, Phone };

    public enum ElectionAdministrationType { VriElectionAdministration };

    public enum VriRequestError { IdentityLookupFailed, Incomplete, Ineligible, InvalidForm, Other };

    public enum ErrorType { VriError };

    public enum VriRequestForm { Fpca, Nvra, Other };

    public enum NameType { VriName };

    public enum PhoneType { VriPhoneContactMethod };

    public enum FluffyType { VriImage };

    public enum VriSignatureSource { Dmv, Local, Other, State, Voter };

    public enum PreviousSignatureType { VriSignature };

    public enum VriSignatureType { Dynamic, Electronic, Other };

    public enum RequestHelperType { VriRequestHelper };

    public enum VriVoterHelperType { Assistant, Witness };

    public enum VriRequestMethod { ArmedForcesRecruitmentOffice, MotorVehicleOffice, Other, OtherAgencyDesignatedByState, PublicAssistanceOffice, RegistrationDriveFromAdvocacyGroupOrPoliticalParty, StateFundedAgencyServingPersonsWithDisabilities, Unknown, VoterViaElectionRegistrarsOffice, VoterViaEmail, VoterViaFax, VoterViaInternet, VoterViaMail };

    public enum RequestProxyType { VriRequestProxy };

    public enum VriRequestProxyType { ArmedForcesRecruitmentOffice, MotorVehicleOffice, Other, OtherAgencyDesignatedByState, PublicAssistanceOffice, RegistrationDriveFromAdvocacyGroupOrPoliticalParty, StateFundedAgencyServingPersonsWithDisabilities };

    public enum PartyType { VriParty };

    public enum SubjectType { VriVoter };

    public enum VriAssertionValue { No, Other, Unknown, Yes };

    public enum VoterClassificationType { VriVoterClassification };

    public enum VriVoterClassificationType { ActivatedNationalGuard, ActiveDuty, ActiveDutySpouseOrDependent, CitizenAbroadIntentToReturn, CitizenAbroadNeverResided, CitizenAbroadReturnUncertain, Deceased, DeclaredIncompetent, EighteenOnElectionDay, Felon, Other, PermanentlyDenied, ProtectedVoter, RestoredFelon, UnitedStatesCitizen };

    public enum VoterIdType { VriVoterId };

    public enum VriVoterIdType { DriversLicense, LocalVoterRegistrationId, Other, Ssn, Ssn4, StateId, StateVoterRegistrationId, Unknown, UnspecifiedDocument, UnspecifiedDocumentWithNameAndAddress, UnspecifiedDocumentWithPhotoIdentification };

    public enum CoordinateType { VriRequestAcknowledgement, VriRequestRejection, VriRequestSuccess, VriVoterRecordResults, VriVoterRecordsRequest };

    public enum VoterRecordType { VriVoterRecord };

    public enum BallotStyleType { VriBallotStyle };

    public enum VoterParticipationType { VriVoterParticipation };

    public enum VriVoterStatus { Active, Inactive, Other };

    public partial class Coordinate
    {
        public static Coordinate FromJson(string json) => JsonSerializer.Deserialize<Coordinate>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Coordinate self) => JsonSerializer.Serialize(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                CoordinateTypeConverter.Singleton,
                VriSuccessActionConverter.Singleton,
                AdditionalInfoTypeConverter.Singleton,
                PurpleTypeConverter.Singleton,
                BallotRequestTypeConverter.Singleton,
                VriBallotReceiptMethodConverter.Singleton,
                ElectionTypeConverter.Singleton,
                ExternalIdentifierTypeConverter.Singleton,
                VriIdentifierTypeConverter.Singleton,
                VriAddressTypeConverter.Singleton,
                AddrTypeAddressClassificationTypeConverter.Singleton,
                AddressCoordinateReferenceSystemTypeConverter.Singleton,
                AddrTypeAddressLifecycleStatusTypeConverter.Singleton,
                AddrTypeAddressRangeDirectionalityTypeConverter.Singleton,
                AddrTypeAddressRangeParityTypeConverter.Singleton,
                AddrTypeAddressRangeSpanTypeConverter.Singleton,
                AddrTypeAddressRangeTypeTypeConverter.Singleton,
                AddrTypeAddressSideOfStreetTypeConverter.Singleton,
                CompleteAddressNumberTypeConverter.Singleton,
                AddrTypeAddressNumberParityTypeConverter.Singleton,
                AddressNumberPrefixTypeConverter.Singleton,
                AddressNumberSuffixTypeConverter.Singleton,
                AddrTypeAttachedElementTypeConverter.Singleton,
                CompleteLandmarkNameTypeConverter.Singleton,
                LandmarkNameTypeConverter.Singleton,
                CompletePlaceNameTypeConverter.Singleton,
                PlaceNameTypeConverter.Singleton,
                AddrTypePlaceNameTypeTypeConverter.Singleton,
                CompleteStreetNameTypeConverter.Singleton,
                StreetNamePostDirectionalTypeConverter.Singleton,
                StreetNamePostModifierTypeConverter.Singleton,
                StreetNamePostTypeTypeConverter.Singleton,
                CompleteSubaddressTypeConverter.Singleton,
                SubaddressElementTypeConverter.Singleton,
                AddrTypeSubaddressComponentOrderTypeConverter.Singleton,
                AddrTypeMailableAddressTypeConverter.Singleton,
                AddrTypeOfficialStatusTypeConverter.Singleton,
                UspsAddressTypeConverter.Singleton,
                UspsBoxTypeConverter.Singleton,
                UspsRouteTypeConverter.Singleton,
                AddrTypeActionTypeConverter.Singleton,
                PollingPlaceTypeConverter.Singleton,
                LocationTypeConverter.Singleton,
                LatLngTypeConverter.Singleton,
                VriReportingUnitTypeConverter.Singleton,
                ElectionAdministrationTypeConverter.Singleton,
                ContactMethodTypeConverter.Singleton,
                VriPhoneCapabilityConverter.Singleton,
                VriContactMethodTypeConverter.Singleton,
                ErrorTypeConverter.Singleton,
                VriRequestErrorConverter.Singleton,
                VriRequestFormConverter.Singleton,
                RequestHelperTypeConverter.Singleton,
                NameTypeConverter.Singleton,
                PhoneTypeConverter.Singleton,
                PreviousSignatureTypeConverter.Singleton,
                FluffyTypeConverter.Singleton,
                VriSignatureSourceConverter.Singleton,
                VriSignatureTypeConverter.Singleton,
                VriVoterHelperTypeConverter.Singleton,
                VriRequestMethodConverter.Singleton,
                RequestProxyTypeConverter.Singleton,
                VriRequestProxyTypeConverter.Singleton,
                SubjectTypeConverter.Singleton,
                PartyTypeConverter.Singleton,
                VoterClassificationTypeConverter.Singleton,
                VriAssertionValueConverter.Singleton,
                VriVoterClassificationTypeConverter.Singleton,
                VoterIdTypeConverter.Singleton,
                VriVoterIdTypeConverter.Singleton,
                VriVoterRequestTypeConverter.Singleton,
                VoterRecordTypeConverter.Singleton,
                VoterParticipationTypeConverter.Singleton,
                BallotStyleTypeConverter.Singleton,
                VriVoterStatusConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class CoordinateTypeConverter : JsonConverter<CoordinateType>
    {
        public override bool CanConvert(Type t) => t == typeof(CoordinateType);

        public override CoordinateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "VRI.RequestAcknowledgement":
                    return CoordinateType.VriRequestAcknowledgement;
                case "VRI.RequestRejection":
                    return CoordinateType.VriRequestRejection;
                case "VRI.RequestSuccess":
                    return CoordinateType.VriRequestSuccess;
                case "VRI.VoterRecordResults":
                    return CoordinateType.VriVoterRecordResults;
                case "VRI.VoterRecordsRequest":
                    return CoordinateType.VriVoterRecordsRequest;
            }
            throw new Exception("Cannot unmarshal type CoordinateType");
        }

        public override void Write(Utf8JsonWriter writer, CoordinateType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case CoordinateType.VriRequestAcknowledgement:
                    JsonSerializer.Serialize(writer, "VRI.RequestAcknowledgement", options);
                    return;
                case CoordinateType.VriRequestRejection:
                    JsonSerializer.Serialize(writer, "VRI.RequestRejection", options);
                    return;
                case CoordinateType.VriRequestSuccess:
                    JsonSerializer.Serialize(writer, "VRI.RequestSuccess", options);
                    return;
                case CoordinateType.VriVoterRecordResults:
                    JsonSerializer.Serialize(writer, "VRI.VoterRecordResults", options);
                    return;
                case CoordinateType.VriVoterRecordsRequest:
                    JsonSerializer.Serialize(writer, "VRI.VoterRecordsRequest", options);
                    return;
            }
            throw new Exception("Cannot marshal type CoordinateType");
        }

        public static readonly CoordinateTypeConverter Singleton = new CoordinateTypeConverter();
    }

    internal class VriSuccessActionConverter : JsonConverter<VriSuccessAction>
    {
        public override bool CanConvert(Type t) => t == typeof(VriSuccessAction);

        public override VriSuccessAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "address-updated":
                    return VriSuccessAction.AddressUpdated;
                case "name-updated":
                    return VriSuccessAction.NameUpdated;
                case "other":
                    return VriSuccessAction.Other;
                case "registration-cancelled":
                    return VriSuccessAction.RegistrationCancelled;
                case "registration-created":
                    return VriSuccessAction.RegistrationCreated;
                case "registration-updated":
                    return VriSuccessAction.RegistrationUpdated;
                case "status-updated":
                    return VriSuccessAction.StatusUpdated;
            }
            throw new Exception("Cannot unmarshal type VriSuccessAction");
        }

        public override void Write(Utf8JsonWriter writer, VriSuccessAction value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriSuccessAction.AddressUpdated:
                    JsonSerializer.Serialize(writer, "address-updated", options);
                    return;
                case VriSuccessAction.NameUpdated:
                    JsonSerializer.Serialize(writer, "name-updated", options);
                    return;
                case VriSuccessAction.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriSuccessAction.RegistrationCancelled:
                    JsonSerializer.Serialize(writer, "registration-cancelled", options);
                    return;
                case VriSuccessAction.RegistrationCreated:
                    JsonSerializer.Serialize(writer, "registration-created", options);
                    return;
                case VriSuccessAction.RegistrationUpdated:
                    JsonSerializer.Serialize(writer, "registration-updated", options);
                    return;
                case VriSuccessAction.StatusUpdated:
                    JsonSerializer.Serialize(writer, "status-updated", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriSuccessAction");
        }

        public static readonly VriSuccessActionConverter Singleton = new VriSuccessActionConverter();
    }

    internal class AdditionalInfoTypeConverter : JsonConverter<AdditionalInfoType>
    {
        public override bool CanConvert(Type t) => t == typeof(AdditionalInfoType);

        public override AdditionalInfoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.AdditionalInfo")
            {
                return AdditionalInfoType.VriAdditionalInfo;
            }
            throw new Exception("Cannot unmarshal type AdditionalInfoType");
        }

        public override void Write(Utf8JsonWriter writer, AdditionalInfoType value, JsonSerializerOptions options)
        {
            if (value == AdditionalInfoType.VriAdditionalInfo)
            {
                JsonSerializer.Serialize(writer, "VRI.AdditionalInfo", options);
                return;
            }
            throw new Exception("Cannot marshal type AdditionalInfoType");
        }

        public static readonly AdditionalInfoTypeConverter Singleton = new AdditionalInfoTypeConverter();
    }

    internal class PurpleTypeConverter : JsonConverter<PurpleType>
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleType);

        public override PurpleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "VRI.File":
                    return PurpleType.VriFile;
                case "VRI.Image":
                    return PurpleType.VriImage;
            }
            throw new Exception("Cannot unmarshal type PurpleType");
        }

        public override void Write(Utf8JsonWriter writer, PurpleType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case PurpleType.VriFile:
                    JsonSerializer.Serialize(writer, "VRI.File", options);
                    return;
                case PurpleType.VriImage:
                    JsonSerializer.Serialize(writer, "VRI.Image", options);
                    return;
            }
            throw new Exception("Cannot marshal type PurpleType");
        }

        public static readonly PurpleTypeConverter Singleton = new PurpleTypeConverter();
    }

    internal class BallotRequestTypeConverter : JsonConverter<BallotRequestType>
    {
        public override bool CanConvert(Type t) => t == typeof(BallotRequestType);

        public override BallotRequestType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "VRI.ElectionBasedBallotRequest":
                    return BallotRequestType.VriElectionBasedBallotRequest;
                case "VRI.PermanentBallotRequest":
                    return BallotRequestType.VriPermanentBallotRequest;
                case "VRI.TemporalBallotRequest":
                    return BallotRequestType.VriTemporalBallotRequest;
            }
            throw new Exception("Cannot unmarshal type BallotRequestType");
        }

        public override void Write(Utf8JsonWriter writer, BallotRequestType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case BallotRequestType.VriElectionBasedBallotRequest:
                    JsonSerializer.Serialize(writer, "VRI.ElectionBasedBallotRequest", options);
                    return;
                case BallotRequestType.VriPermanentBallotRequest:
                    JsonSerializer.Serialize(writer, "VRI.PermanentBallotRequest", options);
                    return;
                case BallotRequestType.VriTemporalBallotRequest:
                    JsonSerializer.Serialize(writer, "VRI.TemporalBallotRequest", options);
                    return;
            }
            throw new Exception("Cannot marshal type BallotRequestType");
        }

        public static readonly BallotRequestTypeConverter Singleton = new BallotRequestTypeConverter();
    }

    internal class VriBallotReceiptMethodConverter : JsonConverter<VriBallotReceiptMethod>
    {
        public override bool CanConvert(Type t) => t == typeof(VriBallotReceiptMethod);

        public override VriBallotReceiptMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "email":
                    return VriBallotReceiptMethod.Email;
                case "email-or-online":
                    return VriBallotReceiptMethod.EmailOrOnline;
                case "fax":
                    return VriBallotReceiptMethod.Fax;
                case "mail":
                    return VriBallotReceiptMethod.Mail;
                case "online":
                    return VriBallotReceiptMethod.Online;
            }
            throw new Exception("Cannot unmarshal type VriBallotReceiptMethod");
        }

        public override void Write(Utf8JsonWriter writer, VriBallotReceiptMethod value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriBallotReceiptMethod.Email:
                    JsonSerializer.Serialize(writer, "email", options);
                    return;
                case VriBallotReceiptMethod.EmailOrOnline:
                    JsonSerializer.Serialize(writer, "email-or-online", options);
                    return;
                case VriBallotReceiptMethod.Fax:
                    JsonSerializer.Serialize(writer, "fax", options);
                    return;
                case VriBallotReceiptMethod.Mail:
                    JsonSerializer.Serialize(writer, "mail", options);
                    return;
                case VriBallotReceiptMethod.Online:
                    JsonSerializer.Serialize(writer, "online", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriBallotReceiptMethod");
        }

        public static readonly VriBallotReceiptMethodConverter Singleton = new VriBallotReceiptMethodConverter();
    }

    internal class ElectionTypeConverter : JsonConverter<ElectionType>
    {
        public override bool CanConvert(Type t) => t == typeof(ElectionType);

        public override ElectionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Election")
            {
                return ElectionType.VriElection;
            }
            throw new Exception("Cannot unmarshal type ElectionType");
        }

        public override void Write(Utf8JsonWriter writer, ElectionType value, JsonSerializerOptions options)
        {
            if (value == ElectionType.VriElection)
            {
                JsonSerializer.Serialize(writer, "VRI.Election", options);
                return;
            }
            throw new Exception("Cannot marshal type ElectionType");
        }

        public static readonly ElectionTypeConverter Singleton = new ElectionTypeConverter();
    }

    internal class ExternalIdentifierTypeConverter : JsonConverter<ExternalIdentifierType>
    {
        public override bool CanConvert(Type t) => t == typeof(ExternalIdentifierType);

        public override ExternalIdentifierType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.ExternalIdentifier")
            {
                return ExternalIdentifierType.VriExternalIdentifier;
            }
            throw new Exception("Cannot unmarshal type ExternalIdentifierType");
        }

        public override void Write(Utf8JsonWriter writer, ExternalIdentifierType value, JsonSerializerOptions options)
        {
            if (value == ExternalIdentifierType.VriExternalIdentifier)
            {
                JsonSerializer.Serialize(writer, "VRI.ExternalIdentifier", options);
                return;
            }
            throw new Exception("Cannot marshal type ExternalIdentifierType");
        }

        public static readonly ExternalIdentifierTypeConverter Singleton = new ExternalIdentifierTypeConverter();
    }

    internal class VriIdentifierTypeConverter : JsonConverter<VriIdentifierType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriIdentifierType);

        public override VriIdentifierType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "fips":
                    return VriIdentifierType.Fips;
                case "local-level":
                    return VriIdentifierType.LocalLevel;
                case "national-level":
                    return VriIdentifierType.NationalLevel;
                case "ocd-id":
                    return VriIdentifierType.OcdId;
                case "other":
                    return VriIdentifierType.Other;
                case "state-level":
                    return VriIdentifierType.StateLevel;
            }
            throw new Exception("Cannot unmarshal type VriIdentifierType");
        }

        public override void Write(Utf8JsonWriter writer, VriIdentifierType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriIdentifierType.Fips:
                    JsonSerializer.Serialize(writer, "fips", options);
                    return;
                case VriIdentifierType.LocalLevel:
                    JsonSerializer.Serialize(writer, "local-level", options);
                    return;
                case VriIdentifierType.NationalLevel:
                    JsonSerializer.Serialize(writer, "national-level", options);
                    return;
                case VriIdentifierType.OcdId:
                    JsonSerializer.Serialize(writer, "ocd-id", options);
                    return;
                case VriIdentifierType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriIdentifierType.StateLevel:
                    JsonSerializer.Serialize(writer, "state-level", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriIdentifierType");
        }

        public static readonly VriIdentifierTypeConverter Singleton = new VriIdentifierTypeConverter();
    }

    internal class VriAddressTypeConverter : JsonConverter<VriAddressType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriAddressType);

        public override VriAddressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "addr.CommunityAddress_type":
                    return VriAddressType.AddrCommunityAddressType;
                case "addr.FourNumberAddressRange_type":
                    return VriAddressType.AddrFourNumberAddressRangeType;
                case "addr.GeneralAddressClass_type":
                    return VriAddressType.AddrGeneralAddressClassType;
                case "addr.IntersectionAddress_type":
                    return VriAddressType.AddrIntersectionAddressType;
                case "addr.LandmarkAddress_type":
                    return VriAddressType.AddrLandmarkAddressType;
                case "addr.NumberedThoroughfareAddress_type":
                    return VriAddressType.AddrNumberedThoroughfareAddressType;
                case "addr.TwoNumberAddressRange_type":
                    return VriAddressType.AddrTwoNumberAddressRangeType;
                case "addr.USPSGeneralDeliveryOffice_type":
                    return VriAddressType.AddrUspsGeneralDeliveryOfficeType;
                case "addr.USPSPostalDeliveryBox_type":
                    return VriAddressType.AddrUspsPostalDeliveryBoxType;
                case "addr.USPSPostalDeliveryRoute_type":
                    return VriAddressType.AddrUspsPostalDeliveryRouteType;
                case "addr.UnnumberedThoroughfareAddress_type":
                    return VriAddressType.AddrUnnumberedThoroughfareAddressType;
            }
            throw new Exception("Cannot unmarshal type VriAddressType");
        }

        public override void Write(Utf8JsonWriter writer, VriAddressType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriAddressType.AddrCommunityAddressType:
                    JsonSerializer.Serialize(writer, "addr.CommunityAddress_type", options);
                    return;
                case VriAddressType.AddrFourNumberAddressRangeType:
                    JsonSerializer.Serialize(writer, "addr.FourNumberAddressRange_type", options);
                    return;
                case VriAddressType.AddrGeneralAddressClassType:
                    JsonSerializer.Serialize(writer, "addr.GeneralAddressClass_type", options);
                    return;
                case VriAddressType.AddrIntersectionAddressType:
                    JsonSerializer.Serialize(writer, "addr.IntersectionAddress_type", options);
                    return;
                case VriAddressType.AddrLandmarkAddressType:
                    JsonSerializer.Serialize(writer, "addr.LandmarkAddress_type", options);
                    return;
                case VriAddressType.AddrNumberedThoroughfareAddressType:
                    JsonSerializer.Serialize(writer, "addr.NumberedThoroughfareAddress_type", options);
                    return;
                case VriAddressType.AddrTwoNumberAddressRangeType:
                    JsonSerializer.Serialize(writer, "addr.TwoNumberAddressRange_type", options);
                    return;
                case VriAddressType.AddrUspsGeneralDeliveryOfficeType:
                    JsonSerializer.Serialize(writer, "addr.USPSGeneralDeliveryOffice_type", options);
                    return;
                case VriAddressType.AddrUspsPostalDeliveryBoxType:
                    JsonSerializer.Serialize(writer, "addr.USPSPostalDeliveryBox_type", options);
                    return;
                case VriAddressType.AddrUspsPostalDeliveryRouteType:
                    JsonSerializer.Serialize(writer, "addr.USPSPostalDeliveryRoute_type", options);
                    return;
                case VriAddressType.AddrUnnumberedThoroughfareAddressType:
                    JsonSerializer.Serialize(writer, "addr.UnnumberedThoroughfareAddress_type", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriAddressType");
        }

        public static readonly VriAddressTypeConverter Singleton = new VriAddressTypeConverter();
    }

    internal class AddrTypeAddressClassificationTypeConverter : JsonConverter<AddrTypeAddressClassificationType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressClassificationType);

        public override AddrTypeAddressClassificationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "CommunityAddress":
                    return AddrTypeAddressClassificationType.CommunityAddress;
                case "FourNumberAddressRange":
                    return AddrTypeAddressClassificationType.FourNumberAddressRange;
                case "GeneralAddressClass":
                    return AddrTypeAddressClassificationType.GeneralAddressClass;
                case "IntersectionAddress":
                    return AddrTypeAddressClassificationType.IntersectionAddress;
                case "LandmarkAddress":
                    return AddrTypeAddressClassificationType.LandmarkAddress;
                case "NumberedThoroughfareAddress":
                    return AddrTypeAddressClassificationType.NumberedThoroughfareAddress;
                case "TwoNumberAddressRange":
                    return AddrTypeAddressClassificationType.TwoNumberAddressRange;
                case "USPSGeneral DeliveryOffice":
                    return AddrTypeAddressClassificationType.UspsGeneralDeliveryOffice;
                case "USPSPostal DeliveryRoute":
                    return AddrTypeAddressClassificationType.UspsPostalDeliveryRoute;
                case "USPSPostalDeliveryBox":
                    return AddrTypeAddressClassificationType.UspsPostalDeliveryBox;
                case "UnnumberedThoroughfareAddress":
                    return AddrTypeAddressClassificationType.UnnumberedThoroughfareAddress;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressClassificationType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressClassificationType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressClassificationType.CommunityAddress:
                    JsonSerializer.Serialize(writer, "CommunityAddress", options);
                    return;
                case AddrTypeAddressClassificationType.FourNumberAddressRange:
                    JsonSerializer.Serialize(writer, "FourNumberAddressRange", options);
                    return;
                case AddrTypeAddressClassificationType.GeneralAddressClass:
                    JsonSerializer.Serialize(writer, "GeneralAddressClass", options);
                    return;
                case AddrTypeAddressClassificationType.IntersectionAddress:
                    JsonSerializer.Serialize(writer, "IntersectionAddress", options);
                    return;
                case AddrTypeAddressClassificationType.LandmarkAddress:
                    JsonSerializer.Serialize(writer, "LandmarkAddress", options);
                    return;
                case AddrTypeAddressClassificationType.NumberedThoroughfareAddress:
                    JsonSerializer.Serialize(writer, "NumberedThoroughfareAddress", options);
                    return;
                case AddrTypeAddressClassificationType.TwoNumberAddressRange:
                    JsonSerializer.Serialize(writer, "TwoNumberAddressRange", options);
                    return;
                case AddrTypeAddressClassificationType.UspsGeneralDeliveryOffice:
                    JsonSerializer.Serialize(writer, "USPSGeneral DeliveryOffice", options);
                    return;
                case AddrTypeAddressClassificationType.UspsPostalDeliveryRoute:
                    JsonSerializer.Serialize(writer, "USPSPostal DeliveryRoute", options);
                    return;
                case AddrTypeAddressClassificationType.UspsPostalDeliveryBox:
                    JsonSerializer.Serialize(writer, "USPSPostalDeliveryBox", options);
                    return;
                case AddrTypeAddressClassificationType.UnnumberedThoroughfareAddress:
                    JsonSerializer.Serialize(writer, "UnnumberedThoroughfareAddress", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressClassificationType");
        }

        public static readonly AddrTypeAddressClassificationTypeConverter Singleton = new AddrTypeAddressClassificationTypeConverter();
    }

    internal class AddressCoordinateReferenceSystemTypeConverter : JsonConverter<AddressCoordinateReferenceSystemType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddressCoordinateReferenceSystemType);

        public override AddressCoordinateReferenceSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.AddressCoordinateReferenceSystem_type")
            {
                return AddressCoordinateReferenceSystemType.AddrTypeAddressCoordinateReferenceSystemType;
            }
            throw new Exception("Cannot unmarshal type AddressCoordinateReferenceSystemType");
        }

        public override void Write(Utf8JsonWriter writer, AddressCoordinateReferenceSystemType value, JsonSerializerOptions options)
        {
            if (value == AddressCoordinateReferenceSystemType.AddrTypeAddressCoordinateReferenceSystemType)
            {
                JsonSerializer.Serialize(writer, "addr_type.AddressCoordinateReferenceSystem_type", options);
                return;
            }
            throw new Exception("Cannot marshal type AddressCoordinateReferenceSystemType");
        }

        public static readonly AddressCoordinateReferenceSystemTypeConverter Singleton = new AddressCoordinateReferenceSystemTypeConverter();
    }

    internal class AddrTypeAddressLifecycleStatusTypeConverter : JsonConverter<AddrTypeAddressLifecycleStatusType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressLifecycleStatusType);

        public override AddrTypeAddressLifecycleStatusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Active":
                    return AddrTypeAddressLifecycleStatusType.Active;
                case "Potential":
                    return AddrTypeAddressLifecycleStatusType.Potential;
                case "Proposed":
                    return AddrTypeAddressLifecycleStatusType.Proposed;
                case "Retired":
                    return AddrTypeAddressLifecycleStatusType.Retired;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressLifecycleStatusType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressLifecycleStatusType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressLifecycleStatusType.Active:
                    JsonSerializer.Serialize(writer, "Active", options);
                    return;
                case AddrTypeAddressLifecycleStatusType.Potential:
                    JsonSerializer.Serialize(writer, "Potential", options);
                    return;
                case AddrTypeAddressLifecycleStatusType.Proposed:
                    JsonSerializer.Serialize(writer, "Proposed", options);
                    return;
                case AddrTypeAddressLifecycleStatusType.Retired:
                    JsonSerializer.Serialize(writer, "Retired", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressLifecycleStatusType");
        }

        public static readonly AddrTypeAddressLifecycleStatusTypeConverter Singleton = new AddrTypeAddressLifecycleStatusTypeConverter();
    }

    internal class AddrTypeAddressRangeDirectionalityTypeConverter : JsonConverter<AddrTypeAddressRangeDirectionalityType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeDirectionalityType);

        public override AddrTypeAddressRangeDirectionalityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Against":
                    return AddrTypeAddressRangeDirectionalityType.Against;
                case "Against-With":
                    return AddrTypeAddressRangeDirectionalityType.AgainstWith;
                case "NA":
                    return AddrTypeAddressRangeDirectionalityType.Na;
                case "Null":
                    return AddrTypeAddressRangeDirectionalityType.Null;
                case "Unknown":
                    return AddrTypeAddressRangeDirectionalityType.Unknown;
                case "With":
                    return AddrTypeAddressRangeDirectionalityType.With;
                case "With-Against":
                    return AddrTypeAddressRangeDirectionalityType.WithAgainst;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressRangeDirectionalityType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressRangeDirectionalityType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressRangeDirectionalityType.Against:
                    JsonSerializer.Serialize(writer, "Against", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.AgainstWith:
                    JsonSerializer.Serialize(writer, "Against-With", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.Na:
                    JsonSerializer.Serialize(writer, "NA", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.Null:
                    JsonSerializer.Serialize(writer, "Null", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.Unknown:
                    JsonSerializer.Serialize(writer, "Unknown", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.With:
                    JsonSerializer.Serialize(writer, "With", options);
                    return;
                case AddrTypeAddressRangeDirectionalityType.WithAgainst:
                    JsonSerializer.Serialize(writer, "With-Against", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeDirectionalityType");
        }

        public static readonly AddrTypeAddressRangeDirectionalityTypeConverter Singleton = new AddrTypeAddressRangeDirectionalityTypeConverter();
    }

    internal class AddrTypeAddressRangeParityTypeConverter : JsonConverter<AddrTypeAddressRangeParityType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeParityType);

        public override AddrTypeAddressRangeParityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "both":
                    return AddrTypeAddressRangeParityType.Both;
                case "even":
                    return AddrTypeAddressRangeParityType.Even;
                case "none":
                    return AddrTypeAddressRangeParityType.None;
                case "odd":
                    return AddrTypeAddressRangeParityType.Odd;
                case "unknown":
                    return AddrTypeAddressRangeParityType.Unknown;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressRangeParityType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressRangeParityType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressRangeParityType.Both:
                    JsonSerializer.Serialize(writer, "both", options);
                    return;
                case AddrTypeAddressRangeParityType.Even:
                    JsonSerializer.Serialize(writer, "even", options);
                    return;
                case AddrTypeAddressRangeParityType.None:
                    JsonSerializer.Serialize(writer, "none", options);
                    return;
                case AddrTypeAddressRangeParityType.Odd:
                    JsonSerializer.Serialize(writer, "odd", options);
                    return;
                case AddrTypeAddressRangeParityType.Unknown:
                    JsonSerializer.Serialize(writer, "unknown", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeParityType");
        }

        public static readonly AddrTypeAddressRangeParityTypeConverter Singleton = new AddrTypeAddressRangeParityTypeConverter();
    }

    internal class AddrTypeAddressRangeSpanTypeConverter : JsonConverter<AddrTypeAddressRangeSpanType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeSpanType);

        public override AddrTypeAddressRangeSpanType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Entire Street":
                    return AddrTypeAddressRangeSpanType.EntireStreet;
                case "Multi Segment":
                    return AddrTypeAddressRangeSpanType.MultiSegment;
                case "Partial Segment":
                    return AddrTypeAddressRangeSpanType.PartialSegment;
                case "Single Segment":
                    return AddrTypeAddressRangeSpanType.SingleSegment;
                case "Unknown":
                    return AddrTypeAddressRangeSpanType.Unknown;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressRangeSpanType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressRangeSpanType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressRangeSpanType.EntireStreet:
                    JsonSerializer.Serialize(writer, "Entire Street", options);
                    return;
                case AddrTypeAddressRangeSpanType.MultiSegment:
                    JsonSerializer.Serialize(writer, "Multi Segment", options);
                    return;
                case AddrTypeAddressRangeSpanType.PartialSegment:
                    JsonSerializer.Serialize(writer, "Partial Segment", options);
                    return;
                case AddrTypeAddressRangeSpanType.SingleSegment:
                    JsonSerializer.Serialize(writer, "Single Segment", options);
                    return;
                case AddrTypeAddressRangeSpanType.Unknown:
                    JsonSerializer.Serialize(writer, "Unknown", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeSpanType");
        }

        public static readonly AddrTypeAddressRangeSpanTypeConverter Singleton = new AddrTypeAddressRangeSpanTypeConverter();
    }

    internal class AddrTypeAddressRangeTypeTypeConverter : JsonConverter<AddrTypeAddressRangeTypeType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeTypeType);

        public override AddrTypeAddressRangeTypeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Actual":
                    return AddrTypeAddressRangeTypeType.Actual;
                case "Potential":
                    return AddrTypeAddressRangeTypeType.Potential;
                case "Unknown":
                    return AddrTypeAddressRangeTypeType.Unknown;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressRangeTypeType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressRangeTypeType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressRangeTypeType.Actual:
                    JsonSerializer.Serialize(writer, "Actual", options);
                    return;
                case AddrTypeAddressRangeTypeType.Potential:
                    JsonSerializer.Serialize(writer, "Potential", options);
                    return;
                case AddrTypeAddressRangeTypeType.Unknown:
                    JsonSerializer.Serialize(writer, "Unknown", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeTypeType");
        }

        public static readonly AddrTypeAddressRangeTypeTypeConverter Singleton = new AddrTypeAddressRangeTypeTypeConverter();
    }

    internal class AddrTypeAddressSideOfStreetTypeConverter : JsonConverter<AddrTypeAddressSideOfStreetType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressSideOfStreetType);

        public override AddrTypeAddressSideOfStreetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "both":
                    return AddrTypeAddressSideOfStreetType.Both;
                case "left":
                    return AddrTypeAddressSideOfStreetType.Left;
                case "none":
                    return AddrTypeAddressSideOfStreetType.None;
                case "right":
                    return AddrTypeAddressSideOfStreetType.Right;
                case "unknown":
                    return AddrTypeAddressSideOfStreetType.Unknown;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressSideOfStreetType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressSideOfStreetType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressSideOfStreetType.Both:
                    JsonSerializer.Serialize(writer, "both", options);
                    return;
                case AddrTypeAddressSideOfStreetType.Left:
                    JsonSerializer.Serialize(writer, "left", options);
                    return;
                case AddrTypeAddressSideOfStreetType.None:
                    JsonSerializer.Serialize(writer, "none", options);
                    return;
                case AddrTypeAddressSideOfStreetType.Right:
                    JsonSerializer.Serialize(writer, "right", options);
                    return;
                case AddrTypeAddressSideOfStreetType.Unknown:
                    JsonSerializer.Serialize(writer, "unknown", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressSideOfStreetType");
        }

        public static readonly AddrTypeAddressSideOfStreetTypeConverter Singleton = new AddrTypeAddressSideOfStreetTypeConverter();
    }

    internal class CompleteAddressNumberTypeConverter : JsonConverter<CompleteAddressNumberType>
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteAddressNumberType);

        public override CompleteAddressNumberType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.CompleteAddressNumber_type")
            {
                return CompleteAddressNumberType.AddrTypeCompleteAddressNumberType;
            }
            throw new Exception("Cannot unmarshal type CompleteAddressNumberType");
        }

        public override void Write(Utf8JsonWriter writer, CompleteAddressNumberType value, JsonSerializerOptions options)
        {
            if (value == CompleteAddressNumberType.AddrTypeCompleteAddressNumberType)
            {
                JsonSerializer.Serialize(writer, "addr_type.CompleteAddressNumber_type", options);
                return;
            }
            throw new Exception("Cannot marshal type CompleteAddressNumberType");
        }

        public static readonly CompleteAddressNumberTypeConverter Singleton = new CompleteAddressNumberTypeConverter();
    }

    internal class AddrTypeAddressNumberParityTypeConverter : JsonConverter<AddrTypeAddressNumberParityType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressNumberParityType);

        public override AddrTypeAddressNumberParityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Even":
                    return AddrTypeAddressNumberParityType.Even;
                case "Odd":
                    return AddrTypeAddressNumberParityType.Odd;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressNumberParityType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAddressNumberParityType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAddressNumberParityType.Even:
                    JsonSerializer.Serialize(writer, "Even", options);
                    return;
                case AddrTypeAddressNumberParityType.Odd:
                    JsonSerializer.Serialize(writer, "Odd", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressNumberParityType");
        }

        public static readonly AddrTypeAddressNumberParityTypeConverter Singleton = new AddrTypeAddressNumberParityTypeConverter();
    }

    internal class AddressNumberPrefixTypeConverter : JsonConverter<AddressNumberPrefixType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddressNumberPrefixType);

        public override AddressNumberPrefixType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.AddressNumberPrefix_type")
            {
                return AddressNumberPrefixType.AddrTypeAddressNumberPrefixType;
            }
            throw new Exception("Cannot unmarshal type AddressNumberPrefixType");
        }

        public override void Write(Utf8JsonWriter writer, AddressNumberPrefixType value, JsonSerializerOptions options)
        {
            if (value == AddressNumberPrefixType.AddrTypeAddressNumberPrefixType)
            {
                JsonSerializer.Serialize(writer, "addr_type.AddressNumberPrefix_type", options);
                return;
            }
            throw new Exception("Cannot marshal type AddressNumberPrefixType");
        }

        public static readonly AddressNumberPrefixTypeConverter Singleton = new AddressNumberPrefixTypeConverter();
    }

    internal class AddressNumberSuffixTypeConverter : JsonConverter<AddressNumberSuffixType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddressNumberSuffixType);

        public override AddressNumberSuffixType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.AddressNumberSuffix_type")
            {
                return AddressNumberSuffixType.AddrTypeAddressNumberSuffixType;
            }
            throw new Exception("Cannot unmarshal type AddressNumberSuffixType");
        }

        public override void Write(Utf8JsonWriter writer, AddressNumberSuffixType value, JsonSerializerOptions options)
        {
            if (value == AddressNumberSuffixType.AddrTypeAddressNumberSuffixType)
            {
                JsonSerializer.Serialize(writer, "addr_type.AddressNumberSuffix_type", options);
                return;
            }
            throw new Exception("Cannot marshal type AddressNumberSuffixType");
        }

        public static readonly AddressNumberSuffixTypeConverter Singleton = new AddressNumberSuffixTypeConverter();
    }

    internal class AddrTypeAttachedElementTypeConverter : JsonConverter<AddrTypeAttachedElementType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAttachedElementType);

        public override AddrTypeAttachedElementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Attached":
                    return AddrTypeAttachedElementType.Attached;
                case "Not Attached":
                    return AddrTypeAttachedElementType.NotAttached;
                case "Unknown":
                    return AddrTypeAttachedElementType.Unknown;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAttachedElementType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeAttachedElementType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeAttachedElementType.Attached:
                    JsonSerializer.Serialize(writer, "Attached", options);
                    return;
                case AddrTypeAttachedElementType.NotAttached:
                    JsonSerializer.Serialize(writer, "Not Attached", options);
                    return;
                case AddrTypeAttachedElementType.Unknown:
                    JsonSerializer.Serialize(writer, "Unknown", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAttachedElementType");
        }

        public static readonly AddrTypeAttachedElementTypeConverter Singleton = new AddrTypeAttachedElementTypeConverter();
    }

    internal class CompleteLandmarkNameTypeConverter : JsonConverter<CompleteLandmarkNameType>
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteLandmarkNameType);

        public override CompleteLandmarkNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.CompleteLandmarkName_type")
            {
                return CompleteLandmarkNameType.AddrTypeCompleteLandmarkNameType;
            }
            throw new Exception("Cannot unmarshal type CompleteLandmarkNameType");
        }

        public override void Write(Utf8JsonWriter writer, CompleteLandmarkNameType value, JsonSerializerOptions options)
        {
            if (value == CompleteLandmarkNameType.AddrTypeCompleteLandmarkNameType)
            {
                JsonSerializer.Serialize(writer, "addr_type.CompleteLandmarkName_type", options);
                return;
            }
            throw new Exception("Cannot marshal type CompleteLandmarkNameType");
        }

        public static readonly CompleteLandmarkNameTypeConverter Singleton = new CompleteLandmarkNameTypeConverter();
    }

    internal class LandmarkNameTypeConverter : JsonConverter<LandmarkNameType>
    {
        public override bool CanConvert(Type t) => t == typeof(LandmarkNameType);

        public override LandmarkNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.LandmarkName_type")
            {
                return LandmarkNameType.AddrTypeLandmarkNameType;
            }
            throw new Exception("Cannot unmarshal type LandmarkNameType");
        }

        public override void Write(Utf8JsonWriter writer, LandmarkNameType value, JsonSerializerOptions options)
        {
            if (value == LandmarkNameType.AddrTypeLandmarkNameType)
            {
                JsonSerializer.Serialize(writer, "addr_type.LandmarkName_type", options);
                return;
            }
            throw new Exception("Cannot marshal type LandmarkNameType");
        }

        public static readonly LandmarkNameTypeConverter Singleton = new LandmarkNameTypeConverter();
    }

    internal class CompletePlaceNameTypeConverter : JsonConverter<CompletePlaceNameType>
    {
        public override bool CanConvert(Type t) => t == typeof(CompletePlaceNameType);

        public override CompletePlaceNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.CompletePlaceName_type")
            {
                return CompletePlaceNameType.AddrTypeCompletePlaceNameType;
            }
            throw new Exception("Cannot unmarshal type CompletePlaceNameType");
        }

        public override void Write(Utf8JsonWriter writer, CompletePlaceNameType value, JsonSerializerOptions options)
        {
            if (value == CompletePlaceNameType.AddrTypeCompletePlaceNameType)
            {
                JsonSerializer.Serialize(writer, "addr_type.CompletePlaceName_type", options);
                return;
            }
            throw new Exception("Cannot marshal type CompletePlaceNameType");
        }

        public static readonly CompletePlaceNameTypeConverter Singleton = new CompletePlaceNameTypeConverter();
    }

    internal class PlaceNameTypeConverter : JsonConverter<PlaceNameType>
    {
        public override bool CanConvert(Type t) => t == typeof(PlaceNameType);

        public override PlaceNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.PlaceName_type")
            {
                return PlaceNameType.AddrTypePlaceNameType;
            }
            throw new Exception("Cannot unmarshal type PlaceNameType");
        }

        public override void Write(Utf8JsonWriter writer, PlaceNameType value, JsonSerializerOptions options)
        {
            if (value == PlaceNameType.AddrTypePlaceNameType)
            {
                JsonSerializer.Serialize(writer, "addr_type.PlaceName_type", options);
                return;
            }
            throw new Exception("Cannot marshal type PlaceNameType");
        }

        public static readonly PlaceNameTypeConverter Singleton = new PlaceNameTypeConverter();
    }

    internal class AddrTypePlaceNameTypeTypeConverter : JsonConverter<AddrTypePlaceNameTypeType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypePlaceNameTypeType);

        public override AddrTypePlaceNameTypeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "County":
                    return AddrTypePlaceNameTypeType.County;
                case "MunicipalJurisdiction":
                    return AddrTypePlaceNameTypeType.MunicipalJurisdiction;
                case "USPSCommunity":
                    return AddrTypePlaceNameTypeType.UspsCommunity;
            }
            throw new Exception("Cannot unmarshal type AddrTypePlaceNameTypeType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypePlaceNameTypeType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypePlaceNameTypeType.County:
                    JsonSerializer.Serialize(writer, "County", options);
                    return;
                case AddrTypePlaceNameTypeType.MunicipalJurisdiction:
                    JsonSerializer.Serialize(writer, "MunicipalJurisdiction", options);
                    return;
                case AddrTypePlaceNameTypeType.UspsCommunity:
                    JsonSerializer.Serialize(writer, "USPSCommunity", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypePlaceNameTypeType");
        }

        public static readonly AddrTypePlaceNameTypeTypeConverter Singleton = new AddrTypePlaceNameTypeTypeConverter();
    }

    internal class CompleteStreetNameTypeConverter : JsonConverter<CompleteStreetNameType>
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteStreetNameType);

        public override CompleteStreetNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.CompleteStreetName_type")
            {
                return CompleteStreetNameType.AddrTypeCompleteStreetNameType;
            }
            throw new Exception("Cannot unmarshal type CompleteStreetNameType");
        }

        public override void Write(Utf8JsonWriter writer, CompleteStreetNameType value, JsonSerializerOptions options)
        {
            if (value == CompleteStreetNameType.AddrTypeCompleteStreetNameType)
            {
                JsonSerializer.Serialize(writer, "addr_type.CompleteStreetName_type", options);
                return;
            }
            throw new Exception("Cannot marshal type CompleteStreetNameType");
        }

        public static readonly CompleteStreetNameTypeConverter Singleton = new CompleteStreetNameTypeConverter();
    }

    internal class StreetNamePostDirectionalTypeConverter : JsonConverter<StreetNamePostDirectionalType>
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostDirectionalType);

        public override StreetNamePostDirectionalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.StreetNamePreDirectional_type")
            {
                return StreetNamePostDirectionalType.AddrTypeStreetNamePreDirectionalType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostDirectionalType");
        }

        public override void Write(Utf8JsonWriter writer, StreetNamePostDirectionalType value, JsonSerializerOptions options)
        {
            if (value == StreetNamePostDirectionalType.AddrTypeStreetNamePreDirectionalType)
            {
                JsonSerializer.Serialize(writer, "addr_type.StreetNamePreDirectional_type", options);
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostDirectionalType");
        }

        public static readonly StreetNamePostDirectionalTypeConverter Singleton = new StreetNamePostDirectionalTypeConverter();
    }

    internal class StreetNamePostModifierTypeConverter : JsonConverter<StreetNamePostModifierType>
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostModifierType);

        public override StreetNamePostModifierType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.StreetNamePreModifier_type")
            {
                return StreetNamePostModifierType.AddrTypeStreetNamePreModifierType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostModifierType");
        }

        public override void Write(Utf8JsonWriter writer, StreetNamePostModifierType value, JsonSerializerOptions options)
        {
            if (value == StreetNamePostModifierType.AddrTypeStreetNamePreModifierType)
            {
                JsonSerializer.Serialize(writer, "addr_type.StreetNamePreModifier_type", options);
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostModifierType");
        }

        public static readonly StreetNamePostModifierTypeConverter Singleton = new StreetNamePostModifierTypeConverter();
    }

    internal class StreetNamePostTypeTypeConverter : JsonConverter<StreetNamePostTypeType>
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostTypeType);

        public override StreetNamePostTypeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.StreetNamePreType_type")
            {
                return StreetNamePostTypeType.AddrTypeStreetNamePreTypeType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostTypeType");
        }

        public override void Write(Utf8JsonWriter writer, StreetNamePostTypeType value, JsonSerializerOptions options)
        {
            if (value == StreetNamePostTypeType.AddrTypeStreetNamePreTypeType)
            {
                JsonSerializer.Serialize(writer, "addr_type.StreetNamePreType_type", options);
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostTypeType");
        }

        public static readonly StreetNamePostTypeTypeConverter Singleton = new StreetNamePostTypeTypeConverter();
    }

    internal class CompleteSubaddressTypeConverter : JsonConverter<CompleteSubaddressType>
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteSubaddressType);

        public override CompleteSubaddressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.CompleteSubaddress_type")
            {
                return CompleteSubaddressType.AddrTypeCompleteSubaddressType;
            }
            throw new Exception("Cannot unmarshal type CompleteSubaddressType");
        }

        public override void Write(Utf8JsonWriter writer, CompleteSubaddressType value, JsonSerializerOptions options)
        {
            if (value == CompleteSubaddressType.AddrTypeCompleteSubaddressType)
            {
                JsonSerializer.Serialize(writer, "addr_type.CompleteSubaddress_type", options);
                return;
            }
            throw new Exception("Cannot marshal type CompleteSubaddressType");
        }

        public static readonly CompleteSubaddressTypeConverter Singleton = new CompleteSubaddressTypeConverter();
    }

    internal class SubaddressElementTypeConverter : JsonConverter<SubaddressElementType>
    {
        public override bool CanConvert(Type t) => t == typeof(SubaddressElementType);

        public override SubaddressElementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.SubaddressElement_type")
            {
                return SubaddressElementType.AddrTypeSubaddressElementType;
            }
            throw new Exception("Cannot unmarshal type SubaddressElementType");
        }

        public override void Write(Utf8JsonWriter writer, SubaddressElementType value, JsonSerializerOptions options)
        {
            if (value == SubaddressElementType.AddrTypeSubaddressElementType)
            {
                JsonSerializer.Serialize(writer, "addr_type.SubaddressElement_type", options);
                return;
            }
            throw new Exception("Cannot marshal type SubaddressElementType");
        }

        public static readonly SubaddressElementTypeConverter Singleton = new SubaddressElementTypeConverter();
    }

    internal class AddrTypeSubaddressComponentOrderTypeConverter : JsonConverter<AddrTypeSubaddressComponentOrderType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeSubaddressComponentOrderType);

        public override AddrTypeSubaddressComponentOrderType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "1":
                    return AddrTypeSubaddressComponentOrderType.The1;
                case "2":
                    return AddrTypeSubaddressComponentOrderType.The2;
                case "3":
                    return AddrTypeSubaddressComponentOrderType.The3;
            }
            throw new Exception("Cannot unmarshal type AddrTypeSubaddressComponentOrderType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeSubaddressComponentOrderType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeSubaddressComponentOrderType.The1:
                    JsonSerializer.Serialize(writer, "1", options);
                    return;
                case AddrTypeSubaddressComponentOrderType.The2:
                    JsonSerializer.Serialize(writer, "2", options);
                    return;
                case AddrTypeSubaddressComponentOrderType.The3:
                    JsonSerializer.Serialize(writer, "3", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeSubaddressComponentOrderType");
        }

        public static readonly AddrTypeSubaddressComponentOrderTypeConverter Singleton = new AddrTypeSubaddressComponentOrderTypeConverter();
    }

    internal class AddrTypeMailableAddressTypeConverter : JsonConverter<AddrTypeMailableAddressType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeMailableAddressType);

        public override AddrTypeMailableAddressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "No":
                    return AddrTypeMailableAddressType.No;
                case "Unknown":
                    return AddrTypeMailableAddressType.Unknown;
                case "Yes":
                    return AddrTypeMailableAddressType.Yes;
            }
            throw new Exception("Cannot unmarshal type AddrTypeMailableAddressType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeMailableAddressType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeMailableAddressType.No:
                    JsonSerializer.Serialize(writer, "No", options);
                    return;
                case AddrTypeMailableAddressType.Unknown:
                    JsonSerializer.Serialize(writer, "Unknown", options);
                    return;
                case AddrTypeMailableAddressType.Yes:
                    JsonSerializer.Serialize(writer, "Yes", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeMailableAddressType");
        }

        public static readonly AddrTypeMailableAddressTypeConverter Singleton = new AddrTypeMailableAddressTypeConverter();
    }

    internal class AddrTypeOfficialStatusTypeConverter : JsonConverter<AddrTypeOfficialStatusType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeOfficialStatusType);

        public override AddrTypeOfficialStatusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Alternate Names Established by Colloquial Use in a Community":
                    return AddrTypeOfficialStatusType.AlternateNamesEstablishedByColloquialUseInACommunity;
                case "Alternate or Alias":
                    return AddrTypeOfficialStatusType.AlternateOrAlias;
                case "Alternates Established by an Address Authority":
                    return AddrTypeOfficialStatusType.AlternatesEstablishedByAnAddressAuthority;
                case "Official":
                    return AddrTypeOfficialStatusType.Official;
                case "Official Alternate or Alias":
                    return AddrTypeOfficialStatusType.OfficialAlternateOrAlias;
                case "Official Renaming Action of the Address Authority":
                    return AddrTypeOfficialStatusType.OfficialRenamingActionOfTheAddressAuthority;
                case "Posted or Vanity Address":
                    return AddrTypeOfficialStatusType.PostedOrVanityAddress;
                case "Unofficial Alternate Names Frequently Encountered":
                    return AddrTypeOfficialStatusType.UnofficialAlternateNamesFrequentlyEncountered;
                case "Unofficial Alternate Names In Use by an Agency or Entity":
                    return AddrTypeOfficialStatusType.UnofficialAlternateNamesInUseByAnAgencyOrEntity;
                case "Unofficial Alternate or Alias":
                    return AddrTypeOfficialStatusType.UnofficialAlternateOrAlias;
                case "Verified Invalid":
                    return AddrTypeOfficialStatusType.VerifiedInvalid;
            }
            throw new Exception("Cannot unmarshal type AddrTypeOfficialStatusType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeOfficialStatusType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeOfficialStatusType.AlternateNamesEstablishedByColloquialUseInACommunity:
                    JsonSerializer.Serialize(writer, "Alternate Names Established by Colloquial Use in a Community", options);
                    return;
                case AddrTypeOfficialStatusType.AlternateOrAlias:
                    JsonSerializer.Serialize(writer, "Alternate or Alias", options);
                    return;
                case AddrTypeOfficialStatusType.AlternatesEstablishedByAnAddressAuthority:
                    JsonSerializer.Serialize(writer, "Alternates Established by an Address Authority", options);
                    return;
                case AddrTypeOfficialStatusType.Official:
                    JsonSerializer.Serialize(writer, "Official", options);
                    return;
                case AddrTypeOfficialStatusType.OfficialAlternateOrAlias:
                    JsonSerializer.Serialize(writer, "Official Alternate or Alias", options);
                    return;
                case AddrTypeOfficialStatusType.OfficialRenamingActionOfTheAddressAuthority:
                    JsonSerializer.Serialize(writer, "Official Renaming Action of the Address Authority", options);
                    return;
                case AddrTypeOfficialStatusType.PostedOrVanityAddress:
                    JsonSerializer.Serialize(writer, "Posted or Vanity Address", options);
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateNamesFrequentlyEncountered:
                    JsonSerializer.Serialize(writer, "Unofficial Alternate Names Frequently Encountered", options);
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateNamesInUseByAnAgencyOrEntity:
                    JsonSerializer.Serialize(writer, "Unofficial Alternate Names In Use by an Agency or Entity", options);
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateOrAlias:
                    JsonSerializer.Serialize(writer, "Unofficial Alternate or Alias", options);
                    return;
                case AddrTypeOfficialStatusType.VerifiedInvalid:
                    JsonSerializer.Serialize(writer, "Verified Invalid", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeOfficialStatusType");
        }

        public static readonly AddrTypeOfficialStatusTypeConverter Singleton = new AddrTypeOfficialStatusTypeConverter();
    }

    internal class UspsAddressTypeConverter : JsonConverter<UspsAddressType>
    {
        public override bool CanConvert(Type t) => t == typeof(UspsAddressType);

        public override UspsAddressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.USPSAddress_type")
            {
                return UspsAddressType.AddrTypeUspsAddressType;
            }
            throw new Exception("Cannot unmarshal type UspsAddressType");
        }

        public override void Write(Utf8JsonWriter writer, UspsAddressType value, JsonSerializerOptions options)
        {
            if (value == UspsAddressType.AddrTypeUspsAddressType)
            {
                JsonSerializer.Serialize(writer, "addr_type.USPSAddress_type", options);
                return;
            }
            throw new Exception("Cannot marshal type UspsAddressType");
        }

        public static readonly UspsAddressTypeConverter Singleton = new UspsAddressTypeConverter();
    }

    internal class UspsBoxTypeConverter : JsonConverter<UspsBoxType>
    {
        public override bool CanConvert(Type t) => t == typeof(UspsBoxType);

        public override UspsBoxType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.USPSBox_type")
            {
                return UspsBoxType.AddrTypeUspsBoxType;
            }
            throw new Exception("Cannot unmarshal type UspsBoxType");
        }

        public override void Write(Utf8JsonWriter writer, UspsBoxType value, JsonSerializerOptions options)
        {
            if (value == UspsBoxType.AddrTypeUspsBoxType)
            {
                JsonSerializer.Serialize(writer, "addr_type.USPSBox_type", options);
                return;
            }
            throw new Exception("Cannot marshal type UspsBoxType");
        }

        public static readonly UspsBoxTypeConverter Singleton = new UspsBoxTypeConverter();
    }

    internal class UspsRouteTypeConverter : JsonConverter<UspsRouteType>
    {
        public override bool CanConvert(Type t) => t == typeof(UspsRouteType);

        public override UspsRouteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "addr_type.USPSRoute_type")
            {
                return UspsRouteType.AddrTypeUspsRouteType;
            }
            throw new Exception("Cannot unmarshal type UspsRouteType");
        }

        public override void Write(Utf8JsonWriter writer, UspsRouteType value, JsonSerializerOptions options)
        {
            if (value == UspsRouteType.AddrTypeUspsRouteType)
            {
                JsonSerializer.Serialize(writer, "addr_type.USPSRoute_type", options);
                return;
            }
            throw new Exception("Cannot marshal type UspsRouteType");
        }

        public static readonly UspsRouteTypeConverter Singleton = new UspsRouteTypeConverter();
    }

    internal class AddrTypeActionTypeConverter : JsonConverter<AddrTypeActionType>
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeActionType);

        public override AddrTypeActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ADD":
                    return AddrTypeActionType.Add;
                case "DELETE":
                    return AddrTypeActionType.Delete;
            }
            throw new Exception("Cannot unmarshal type AddrTypeActionType");
        }

        public override void Write(Utf8JsonWriter writer, AddrTypeActionType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case AddrTypeActionType.Add:
                    JsonSerializer.Serialize(writer, "ADD", options);
                    return;
                case AddrTypeActionType.Delete:
                    JsonSerializer.Serialize(writer, "DELETE", options);
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeActionType");
        }

        public static readonly AddrTypeActionTypeConverter Singleton = new AddrTypeActionTypeConverter();
    }

    internal class PollingPlaceTypeConverter : JsonConverter<PollingPlaceType>
    {
        public override bool CanConvert(Type t) => t == typeof(PollingPlaceType);

        public override PollingPlaceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.ReportingUnit")
            {
                return PollingPlaceType.VriReportingUnit;
            }
            throw new Exception("Cannot unmarshal type PollingPlaceType");
        }

        public override void Write(Utf8JsonWriter writer, PollingPlaceType value, JsonSerializerOptions options)
        {
            if (value == PollingPlaceType.VriReportingUnit)
            {
                JsonSerializer.Serialize(writer, "VRI.ReportingUnit", options);
                return;
            }
            throw new Exception("Cannot marshal type PollingPlaceType");
        }

        public static readonly PollingPlaceTypeConverter Singleton = new PollingPlaceTypeConverter();
    }

    internal class LocationTypeConverter : JsonConverter<LocationType>
    {
        public override bool CanConvert(Type t) => t == typeof(LocationType);

        public override LocationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Location")
            {
                return LocationType.VriLocation;
            }
            throw new Exception("Cannot unmarshal type LocationType");
        }

        public override void Write(Utf8JsonWriter writer, LocationType value, JsonSerializerOptions options)
        {
            if (value == LocationType.VriLocation)
            {
                JsonSerializer.Serialize(writer, "VRI.Location", options);
                return;
            }
            throw new Exception("Cannot marshal type LocationType");
        }

        public static readonly LocationTypeConverter Singleton = new LocationTypeConverter();
    }

    internal class LatLngTypeConverter : JsonConverter<LatLngType>
    {
        public override bool CanConvert(Type t) => t == typeof(LatLngType);

        public override LatLngType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.LatLng")
            {
                return LatLngType.VriLatLng;
            }
            throw new Exception("Cannot unmarshal type LatLngType");
        }

        public override void Write(Utf8JsonWriter writer, LatLngType value, JsonSerializerOptions options)
        {
            if (value == LatLngType.VriLatLng)
            {
                JsonSerializer.Serialize(writer, "VRI.LatLng", options);
                return;
            }
            throw new Exception("Cannot marshal type LatLngType");
        }

        public static readonly LatLngTypeConverter Singleton = new LatLngTypeConverter();
    }

    internal class VriReportingUnitTypeConverter : JsonConverter<VriReportingUnitType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriReportingUnitType);

        public override VriReportingUnitType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ballot-batch":
                    return VriReportingUnitType.BallotBatch;
                case "ballot-style-area":
                    return VriReportingUnitType.BallotStyleArea;
                case "borough":
                    return VriReportingUnitType.Borough;
                case "city":
                    return VriReportingUnitType.City;
                case "city-council":
                    return VriReportingUnitType.CityCouncil;
                case "combined-precinct":
                    return VriReportingUnitType.CombinedPrecinct;
                case "congressional":
                    return VriReportingUnitType.Congressional;
                case "county":
                    return VriReportingUnitType.County;
                case "county-council":
                    return VriReportingUnitType.CountyCouncil;
                case "drop-box":
                    return VriReportingUnitType.DropBox;
                case "judicial":
                    return VriReportingUnitType.Judicial;
                case "municipality":
                    return VriReportingUnitType.Municipality;
                case "other":
                    return VriReportingUnitType.Other;
                case "polling-place":
                    return VriReportingUnitType.PollingPlace;
                case "precinct":
                    return VriReportingUnitType.Precinct;
                case "school":
                    return VriReportingUnitType.School;
                case "special":
                    return VriReportingUnitType.Special;
                case "split-precinct":
                    return VriReportingUnitType.SplitPrecinct;
                case "state":
                    return VriReportingUnitType.State;
                case "state-house":
                    return VriReportingUnitType.StateHouse;
                case "state-senate":
                    return VriReportingUnitType.StateSenate;
                case "town":
                    return VriReportingUnitType.Town;
                case "township":
                    return VriReportingUnitType.Township;
                case "utility":
                    return VriReportingUnitType.Utility;
                case "village":
                    return VriReportingUnitType.Village;
                case "vote-center":
                    return VriReportingUnitType.VoteCenter;
                case "ward":
                    return VriReportingUnitType.Ward;
                case "water":
                    return VriReportingUnitType.Water;
            }
            throw new Exception("Cannot unmarshal type VriReportingUnitType");
        }

        public override void Write(Utf8JsonWriter writer, VriReportingUnitType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriReportingUnitType.BallotBatch:
                    JsonSerializer.Serialize(writer, "ballot-batch", options);
                    return;
                case VriReportingUnitType.BallotStyleArea:
                    JsonSerializer.Serialize(writer, "ballot-style-area", options);
                    return;
                case VriReportingUnitType.Borough:
                    JsonSerializer.Serialize(writer, "borough", options);
                    return;
                case VriReportingUnitType.City:
                    JsonSerializer.Serialize(writer, "city", options);
                    return;
                case VriReportingUnitType.CityCouncil:
                    JsonSerializer.Serialize(writer, "city-council", options);
                    return;
                case VriReportingUnitType.CombinedPrecinct:
                    JsonSerializer.Serialize(writer, "combined-precinct", options);
                    return;
                case VriReportingUnitType.Congressional:
                    JsonSerializer.Serialize(writer, "congressional", options);
                    return;
                case VriReportingUnitType.County:
                    JsonSerializer.Serialize(writer, "county", options);
                    return;
                case VriReportingUnitType.CountyCouncil:
                    JsonSerializer.Serialize(writer, "county-council", options);
                    return;
                case VriReportingUnitType.DropBox:
                    JsonSerializer.Serialize(writer, "drop-box", options);
                    return;
                case VriReportingUnitType.Judicial:
                    JsonSerializer.Serialize(writer, "judicial", options);
                    return;
                case VriReportingUnitType.Municipality:
                    JsonSerializer.Serialize(writer, "municipality", options);
                    return;
                case VriReportingUnitType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriReportingUnitType.PollingPlace:
                    JsonSerializer.Serialize(writer, "polling-place", options);
                    return;
                case VriReportingUnitType.Precinct:
                    JsonSerializer.Serialize(writer, "precinct", options);
                    return;
                case VriReportingUnitType.School:
                    JsonSerializer.Serialize(writer, "school", options);
                    return;
                case VriReportingUnitType.Special:
                    JsonSerializer.Serialize(writer, "special", options);
                    return;
                case VriReportingUnitType.SplitPrecinct:
                    JsonSerializer.Serialize(writer, "split-precinct", options);
                    return;
                case VriReportingUnitType.State:
                    JsonSerializer.Serialize(writer, "state", options);
                    return;
                case VriReportingUnitType.StateHouse:
                    JsonSerializer.Serialize(writer, "state-house", options);
                    return;
                case VriReportingUnitType.StateSenate:
                    JsonSerializer.Serialize(writer, "state-senate", options);
                    return;
                case VriReportingUnitType.Town:
                    JsonSerializer.Serialize(writer, "town", options);
                    return;
                case VriReportingUnitType.Township:
                    JsonSerializer.Serialize(writer, "township", options);
                    return;
                case VriReportingUnitType.Utility:
                    JsonSerializer.Serialize(writer, "utility", options);
                    return;
                case VriReportingUnitType.Village:
                    JsonSerializer.Serialize(writer, "village", options);
                    return;
                case VriReportingUnitType.VoteCenter:
                    JsonSerializer.Serialize(writer, "vote-center", options);
                    return;
                case VriReportingUnitType.Ward:
                    JsonSerializer.Serialize(writer, "ward", options);
                    return;
                case VriReportingUnitType.Water:
                    JsonSerializer.Serialize(writer, "water", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriReportingUnitType");
        }

        public static readonly VriReportingUnitTypeConverter Singleton = new VriReportingUnitTypeConverter();
    }

    internal class ElectionAdministrationTypeConverter : JsonConverter<ElectionAdministrationType>
    {
        public override bool CanConvert(Type t) => t == typeof(ElectionAdministrationType);

        public override ElectionAdministrationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.ElectionAdministration")
            {
                return ElectionAdministrationType.VriElectionAdministration;
            }
            throw new Exception("Cannot unmarshal type ElectionAdministrationType");
        }

        public override void Write(Utf8JsonWriter writer, ElectionAdministrationType value, JsonSerializerOptions options)
        {
            if (value == ElectionAdministrationType.VriElectionAdministration)
            {
                JsonSerializer.Serialize(writer, "VRI.ElectionAdministration", options);
                return;
            }
            throw new Exception("Cannot marshal type ElectionAdministrationType");
        }

        public static readonly ElectionAdministrationTypeConverter Singleton = new ElectionAdministrationTypeConverter();
    }

    internal class ContactMethodTypeConverter : JsonConverter<ContactMethodType>
    {
        public override bool CanConvert(Type t) => t == typeof(ContactMethodType);

        public override ContactMethodType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "VRI.ContactMethod":
                    return ContactMethodType.VriContactMethod;
                case "VRI.PhoneContactMethod":
                    return ContactMethodType.VriPhoneContactMethod;
            }
            throw new Exception("Cannot unmarshal type ContactMethodType");
        }

        public override void Write(Utf8JsonWriter writer, ContactMethodType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ContactMethodType.VriContactMethod:
                    JsonSerializer.Serialize(writer, "VRI.ContactMethod", options);
                    return;
                case ContactMethodType.VriPhoneContactMethod:
                    JsonSerializer.Serialize(writer, "VRI.PhoneContactMethod", options);
                    return;
            }
            throw new Exception("Cannot marshal type ContactMethodType");
        }

        public static readonly ContactMethodTypeConverter Singleton = new ContactMethodTypeConverter();
    }

    internal class VriPhoneCapabilityConverter : JsonConverter<VriPhoneCapability>
    {
        public override bool CanConvert(Type t) => t == typeof(VriPhoneCapability);

        public override VriPhoneCapability Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "fax":
                    return VriPhoneCapability.Fax;
                case "mms":
                    return VriPhoneCapability.Mms;
                case "sms":
                    return VriPhoneCapability.Sms;
                case "voice":
                    return VriPhoneCapability.Voice;
            }
            throw new Exception("Cannot unmarshal type VriPhoneCapability");
        }

        public override void Write(Utf8JsonWriter writer, VriPhoneCapability value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriPhoneCapability.Fax:
                    JsonSerializer.Serialize(writer, "fax", options);
                    return;
                case VriPhoneCapability.Mms:
                    JsonSerializer.Serialize(writer, "mms", options);
                    return;
                case VriPhoneCapability.Sms:
                    JsonSerializer.Serialize(writer, "sms", options);
                    return;
                case VriPhoneCapability.Voice:
                    JsonSerializer.Serialize(writer, "voice", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriPhoneCapability");
        }

        public static readonly VriPhoneCapabilityConverter Singleton = new VriPhoneCapabilityConverter();
    }

    internal class VriContactMethodTypeConverter : JsonConverter<VriContactMethodType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriContactMethodType);

        public override VriContactMethodType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "email":
                    return VriContactMethodType.Email;
                case "other":
                    return VriContactMethodType.Other;
                case "phone":
                    return VriContactMethodType.Phone;
            }
            throw new Exception("Cannot unmarshal type VriContactMethodType");
        }

        public override void Write(Utf8JsonWriter writer, VriContactMethodType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriContactMethodType.Email:
                    JsonSerializer.Serialize(writer, "email", options);
                    return;
                case VriContactMethodType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriContactMethodType.Phone:
                    JsonSerializer.Serialize(writer, "phone", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriContactMethodType");
        }

        public static readonly VriContactMethodTypeConverter Singleton = new VriContactMethodTypeConverter();
    }

    internal class ErrorTypeConverter : JsonConverter<ErrorType>
    {
        public override bool CanConvert(Type t) => t == typeof(ErrorType);

        public override ErrorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Error")
            {
                return ErrorType.VriError;
            }
            throw new Exception("Cannot unmarshal type ErrorType");
        }

        public override void Write(Utf8JsonWriter writer, ErrorType value, JsonSerializerOptions options)
        {
            if (value == ErrorType.VriError)
            {
                JsonSerializer.Serialize(writer, "VRI.Error", options);
                return;
            }
            throw new Exception("Cannot marshal type ErrorType");
        }

        public static readonly ErrorTypeConverter Singleton = new ErrorTypeConverter();
    }

    internal class VriRequestErrorConverter : JsonConverter<VriRequestError>
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestError);

        public override VriRequestError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "identity-lookup-failed":
                    return VriRequestError.IdentityLookupFailed;
                case "incomplete":
                    return VriRequestError.Incomplete;
                case "ineligible":
                    return VriRequestError.Ineligible;
                case "invalid-form":
                    return VriRequestError.InvalidForm;
                case "other":
                    return VriRequestError.Other;
            }
            throw new Exception("Cannot unmarshal type VriRequestError");
        }

        public override void Write(Utf8JsonWriter writer, VriRequestError value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriRequestError.IdentityLookupFailed:
                    JsonSerializer.Serialize(writer, "identity-lookup-failed", options);
                    return;
                case VriRequestError.Incomplete:
                    JsonSerializer.Serialize(writer, "incomplete", options);
                    return;
                case VriRequestError.Ineligible:
                    JsonSerializer.Serialize(writer, "ineligible", options);
                    return;
                case VriRequestError.InvalidForm:
                    JsonSerializer.Serialize(writer, "invalid-form", options);
                    return;
                case VriRequestError.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestError");
        }

        public static readonly VriRequestErrorConverter Singleton = new VriRequestErrorConverter();
    }

    internal class VriRequestFormConverter : JsonConverter<VriRequestForm>
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestForm);

        public override VriRequestForm Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "fpca":
                    return VriRequestForm.Fpca;
                case "nvra":
                    return VriRequestForm.Nvra;
                case "other":
                    return VriRequestForm.Other;
            }
            throw new Exception("Cannot unmarshal type VriRequestForm");
        }

        public override void Write(Utf8JsonWriter writer, VriRequestForm value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriRequestForm.Fpca:
                    JsonSerializer.Serialize(writer, "fpca", options);
                    return;
                case VriRequestForm.Nvra:
                    JsonSerializer.Serialize(writer, "nvra", options);
                    return;
                case VriRequestForm.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestForm");
        }

        public static readonly VriRequestFormConverter Singleton = new VriRequestFormConverter();
    }

    internal class RequestHelperTypeConverter : JsonConverter<RequestHelperType>
    {
        public override bool CanConvert(Type t) => t == typeof(RequestHelperType);

        public override RequestHelperType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.RequestHelper")
            {
                return RequestHelperType.VriRequestHelper;
            }
            throw new Exception("Cannot unmarshal type RequestHelperType");
        }

        public override void Write(Utf8JsonWriter writer, RequestHelperType value, JsonSerializerOptions options)
        {
            if (value == RequestHelperType.VriRequestHelper)
            {
                JsonSerializer.Serialize(writer, "VRI.RequestHelper", options);
                return;
            }
            throw new Exception("Cannot marshal type RequestHelperType");
        }

        public static readonly RequestHelperTypeConverter Singleton = new RequestHelperTypeConverter();
    }

    internal class NameTypeConverter : JsonConverter<NameType>
    {
        public override bool CanConvert(Type t) => t == typeof(NameType);

        public override NameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Name")
            {
                return NameType.VriName;
            }
            throw new Exception("Cannot unmarshal type NameType");
        }

        public override void Write(Utf8JsonWriter writer, NameType value, JsonSerializerOptions options)
        {
            if (value == NameType.VriName)
            {
                JsonSerializer.Serialize(writer, "VRI.Name", options);
                return;
            }
            throw new Exception("Cannot marshal type NameType");
        }

        public static readonly NameTypeConverter Singleton = new NameTypeConverter();
    }

    internal class PhoneTypeConverter : JsonConverter<PhoneType>
    {
        public override bool CanConvert(Type t) => t == typeof(PhoneType);

        public override PhoneType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.PhoneContactMethod")
            {
                return PhoneType.VriPhoneContactMethod;
            }
            throw new Exception("Cannot unmarshal type PhoneType");
        }

        public override void Write(Utf8JsonWriter writer, PhoneType value, JsonSerializerOptions options)
        {
            if (value == PhoneType.VriPhoneContactMethod)
            {
                JsonSerializer.Serialize(writer, "VRI.PhoneContactMethod", options);
                return;
            }
            throw new Exception("Cannot marshal type PhoneType");
        }

        public static readonly PhoneTypeConverter Singleton = new PhoneTypeConverter();
    }

    internal class PreviousSignatureTypeConverter : JsonConverter<PreviousSignatureType>
    {
        public override bool CanConvert(Type t) => t == typeof(PreviousSignatureType);

        public override PreviousSignatureType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Signature")
            {
                return PreviousSignatureType.VriSignature;
            }
            throw new Exception("Cannot unmarshal type PreviousSignatureType");
        }

        public override void Write(Utf8JsonWriter writer, PreviousSignatureType value, JsonSerializerOptions options)
        {
            if (value == PreviousSignatureType.VriSignature)
            {
                JsonSerializer.Serialize(writer, "VRI.Signature", options);
                return;
            }
            throw new Exception("Cannot marshal type PreviousSignatureType");
        }

        public static readonly PreviousSignatureTypeConverter Singleton = new PreviousSignatureTypeConverter();
    }

    internal class FluffyTypeConverter : JsonConverter<FluffyType>
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyType);

        public override FluffyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Image")
            {
                return FluffyType.VriImage;
            }
            throw new Exception("Cannot unmarshal type FluffyType");
        }

        public override void Write(Utf8JsonWriter writer, FluffyType value, JsonSerializerOptions options)
        {
            if (value == FluffyType.VriImage)
            {
                JsonSerializer.Serialize(writer, "VRI.Image", options);
                return;
            }
            throw new Exception("Cannot marshal type FluffyType");
        }

        public static readonly FluffyTypeConverter Singleton = new FluffyTypeConverter();
    }

    internal class VriSignatureSourceConverter : JsonConverter<VriSignatureSource>
    {
        public override bool CanConvert(Type t) => t == typeof(VriSignatureSource);

        public override VriSignatureSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "dmv":
                    return VriSignatureSource.Dmv;
                case "local":
                    return VriSignatureSource.Local;
                case "other":
                    return VriSignatureSource.Other;
                case "state":
                    return VriSignatureSource.State;
                case "voter":
                    return VriSignatureSource.Voter;
            }
            throw new Exception("Cannot unmarshal type VriSignatureSource");
        }

        public override void Write(Utf8JsonWriter writer, VriSignatureSource value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriSignatureSource.Dmv:
                    JsonSerializer.Serialize(writer, "dmv", options);
                    return;
                case VriSignatureSource.Local:
                    JsonSerializer.Serialize(writer, "local", options);
                    return;
                case VriSignatureSource.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriSignatureSource.State:
                    JsonSerializer.Serialize(writer, "state", options);
                    return;
                case VriSignatureSource.Voter:
                    JsonSerializer.Serialize(writer, "voter", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriSignatureSource");
        }

        public static readonly VriSignatureSourceConverter Singleton = new VriSignatureSourceConverter();
    }

    internal class VriSignatureTypeConverter : JsonConverter<VriSignatureType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriSignatureType);

        public override VriSignatureType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "dynamic":
                    return VriSignatureType.Dynamic;
                case "electronic":
                    return VriSignatureType.Electronic;
                case "other":
                    return VriSignatureType.Other;
            }
            throw new Exception("Cannot unmarshal type VriSignatureType");
        }

        public override void Write(Utf8JsonWriter writer, VriSignatureType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriSignatureType.Dynamic:
                    JsonSerializer.Serialize(writer, "dynamic", options);
                    return;
                case VriSignatureType.Electronic:
                    JsonSerializer.Serialize(writer, "electronic", options);
                    return;
                case VriSignatureType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriSignatureType");
        }

        public static readonly VriSignatureTypeConverter Singleton = new VriSignatureTypeConverter();
    }

    internal class VriVoterHelperTypeConverter : JsonConverter<VriVoterHelperType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterHelperType);

        public override VriVoterHelperType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "assistant":
                    return VriVoterHelperType.Assistant;
                case "witness":
                    return VriVoterHelperType.Witness;
            }
            throw new Exception("Cannot unmarshal type VriVoterHelperType");
        }

        public override void Write(Utf8JsonWriter writer, VriVoterHelperType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriVoterHelperType.Assistant:
                    JsonSerializer.Serialize(writer, "assistant", options);
                    return;
                case VriVoterHelperType.Witness:
                    JsonSerializer.Serialize(writer, "witness", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterHelperType");
        }

        public static readonly VriVoterHelperTypeConverter Singleton = new VriVoterHelperTypeConverter();
    }

    internal class VriRequestMethodConverter : JsonConverter<VriRequestMethod>
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestMethod);

        public override VriRequestMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "armed-forces-recruitment-office":
                    return VriRequestMethod.ArmedForcesRecruitmentOffice;
                case "motor-vehicle-office":
                    return VriRequestMethod.MotorVehicleOffice;
                case "other":
                    return VriRequestMethod.Other;
                case "other-agency-designated-by-state":
                    return VriRequestMethod.OtherAgencyDesignatedByState;
                case "public-assistance-office":
                    return VriRequestMethod.PublicAssistanceOffice;
                case "registration-drive-from-advocacy-group-or-political-party":
                    return VriRequestMethod.RegistrationDriveFromAdvocacyGroupOrPoliticalParty;
                case "state-funded-agency-serving-persons-with-disabilities":
                    return VriRequestMethod.StateFundedAgencyServingPersonsWithDisabilities;
                case "unknown":
                    return VriRequestMethod.Unknown;
                case "voter-via-election-registrars-office":
                    return VriRequestMethod.VoterViaElectionRegistrarsOffice;
                case "voter-via-email":
                    return VriRequestMethod.VoterViaEmail;
                case "voter-via-fax":
                    return VriRequestMethod.VoterViaFax;
                case "voter-via-internet":
                    return VriRequestMethod.VoterViaInternet;
                case "voter-via-mail":
                    return VriRequestMethod.VoterViaMail;
            }
            throw new Exception("Cannot unmarshal type VriRequestMethod");
        }

        public override void Write(Utf8JsonWriter writer, VriRequestMethod value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriRequestMethod.ArmedForcesRecruitmentOffice:
                    JsonSerializer.Serialize(writer, "armed-forces-recruitment-office", options);
                    return;
                case VriRequestMethod.MotorVehicleOffice:
                    JsonSerializer.Serialize(writer, "motor-vehicle-office", options);
                    return;
                case VriRequestMethod.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriRequestMethod.OtherAgencyDesignatedByState:
                    JsonSerializer.Serialize(writer, "other-agency-designated-by-state", options);
                    return;
                case VriRequestMethod.PublicAssistanceOffice:
                    JsonSerializer.Serialize(writer, "public-assistance-office", options);
                    return;
                case VriRequestMethod.RegistrationDriveFromAdvocacyGroupOrPoliticalParty:
                    JsonSerializer.Serialize(writer, "registration-drive-from-advocacy-group-or-political-party", options);
                    return;
                case VriRequestMethod.StateFundedAgencyServingPersonsWithDisabilities:
                    JsonSerializer.Serialize(writer, "state-funded-agency-serving-persons-with-disabilities", options);
                    return;
                case VriRequestMethod.Unknown:
                    JsonSerializer.Serialize(writer, "unknown", options);
                    return;
                case VriRequestMethod.VoterViaElectionRegistrarsOffice:
                    JsonSerializer.Serialize(writer, "voter-via-election-registrars-office", options);
                    return;
                case VriRequestMethod.VoterViaEmail:
                    JsonSerializer.Serialize(writer, "voter-via-email", options);
                    return;
                case VriRequestMethod.VoterViaFax:
                    JsonSerializer.Serialize(writer, "voter-via-fax", options);
                    return;
                case VriRequestMethod.VoterViaInternet:
                    JsonSerializer.Serialize(writer, "voter-via-internet", options);
                    return;
                case VriRequestMethod.VoterViaMail:
                    JsonSerializer.Serialize(writer, "voter-via-mail", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestMethod");
        }

        public static readonly VriRequestMethodConverter Singleton = new VriRequestMethodConverter();
    }

    internal class RequestProxyTypeConverter : JsonConverter<RequestProxyType>
    {
        public override bool CanConvert(Type t) => t == typeof(RequestProxyType);

        public override RequestProxyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.RequestProxy")
            {
                return RequestProxyType.VriRequestProxy;
            }
            throw new Exception("Cannot unmarshal type RequestProxyType");
        }

        public override void Write(Utf8JsonWriter writer, RequestProxyType value, JsonSerializerOptions options)
        {
            if (value == RequestProxyType.VriRequestProxy)
            {
                JsonSerializer.Serialize(writer, "VRI.RequestProxy", options);
                return;
            }
            throw new Exception("Cannot marshal type RequestProxyType");
        }

        public static readonly RequestProxyTypeConverter Singleton = new RequestProxyTypeConverter();
    }

    internal class VriRequestProxyTypeConverter : JsonConverter<VriRequestProxyType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestProxyType);

        public override VriRequestProxyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "armed-forces-recruitment-office":
                    return VriRequestProxyType.ArmedForcesRecruitmentOffice;
                case "motor-vehicle-office":
                    return VriRequestProxyType.MotorVehicleOffice;
                case "other":
                    return VriRequestProxyType.Other;
                case "other-agency-designated-by-state":
                    return VriRequestProxyType.OtherAgencyDesignatedByState;
                case "public-assistance-office":
                    return VriRequestProxyType.PublicAssistanceOffice;
                case "registration-drive-from-advocacy-group-or-political-party":
                    return VriRequestProxyType.RegistrationDriveFromAdvocacyGroupOrPoliticalParty;
                case "state-funded-agency-serving-persons-with-disabilities":
                    return VriRequestProxyType.StateFundedAgencyServingPersonsWithDisabilities;
            }
            throw new Exception("Cannot unmarshal type VriRequestProxyType");
        }

        public override void Write(Utf8JsonWriter writer, VriRequestProxyType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriRequestProxyType.ArmedForcesRecruitmentOffice:
                    JsonSerializer.Serialize(writer, "armed-forces-recruitment-office", options);
                    return;
                case VriRequestProxyType.MotorVehicleOffice:
                    JsonSerializer.Serialize(writer, "motor-vehicle-office", options);
                    return;
                case VriRequestProxyType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriRequestProxyType.OtherAgencyDesignatedByState:
                    JsonSerializer.Serialize(writer, "other-agency-designated-by-state", options);
                    return;
                case VriRequestProxyType.PublicAssistanceOffice:
                    JsonSerializer.Serialize(writer, "public-assistance-office", options);
                    return;
                case VriRequestProxyType.RegistrationDriveFromAdvocacyGroupOrPoliticalParty:
                    JsonSerializer.Serialize(writer, "registration-drive-from-advocacy-group-or-political-party", options);
                    return;
                case VriRequestProxyType.StateFundedAgencyServingPersonsWithDisabilities:
                    JsonSerializer.Serialize(writer, "state-funded-agency-serving-persons-with-disabilities", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestProxyType");
        }

        public static readonly VriRequestProxyTypeConverter Singleton = new VriRequestProxyTypeConverter();
    }

    internal class SubjectTypeConverter : JsonConverter<SubjectType>
    {
        public override bool CanConvert(Type t) => t == typeof(SubjectType);

        public override SubjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Voter")
            {
                return SubjectType.VriVoter;
            }
            throw new Exception("Cannot unmarshal type SubjectType");
        }

        public override void Write(Utf8JsonWriter writer, SubjectType value, JsonSerializerOptions options)
        {
            if (value == SubjectType.VriVoter)
            {
                JsonSerializer.Serialize(writer, "VRI.Voter", options);
                return;
            }
            throw new Exception("Cannot marshal type SubjectType");
        }

        public static readonly SubjectTypeConverter Singleton = new SubjectTypeConverter();
    }

    internal class PartyTypeConverter : JsonConverter<PartyType>
    {
        public override bool CanConvert(Type t) => t == typeof(PartyType);

        public override PartyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.Party")
            {
                return PartyType.VriParty;
            }
            throw new Exception("Cannot unmarshal type PartyType");
        }

        public override void Write(Utf8JsonWriter writer, PartyType value, JsonSerializerOptions options)
        {
            if (value == PartyType.VriParty)
            {
                JsonSerializer.Serialize(writer, "VRI.Party", options);
                return;
            }
            throw new Exception("Cannot marshal type PartyType");
        }

        public static readonly PartyTypeConverter Singleton = new PartyTypeConverter();
    }

    internal class VoterClassificationTypeConverter : JsonConverter<VoterClassificationType>
    {
        public override bool CanConvert(Type t) => t == typeof(VoterClassificationType);

        public override VoterClassificationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.VoterClassification")
            {
                return VoterClassificationType.VriVoterClassification;
            }
            throw new Exception("Cannot unmarshal type VoterClassificationType");
        }

        public override void Write(Utf8JsonWriter writer, VoterClassificationType value, JsonSerializerOptions options)
        {
            if (value == VoterClassificationType.VriVoterClassification)
            {
                JsonSerializer.Serialize(writer, "VRI.VoterClassification", options);
                return;
            }
            throw new Exception("Cannot marshal type VoterClassificationType");
        }

        public static readonly VoterClassificationTypeConverter Singleton = new VoterClassificationTypeConverter();
    }

    internal class VriAssertionValueConverter : JsonConverter<VriAssertionValue>
    {
        public override bool CanConvert(Type t) => t == typeof(VriAssertionValue);

        public override VriAssertionValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "no":
                    return VriAssertionValue.No;
                case "other":
                    return VriAssertionValue.Other;
                case "unknown":
                    return VriAssertionValue.Unknown;
                case "yes":
                    return VriAssertionValue.Yes;
            }
            throw new Exception("Cannot unmarshal type VriAssertionValue");
        }

        public override void Write(Utf8JsonWriter writer, VriAssertionValue value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriAssertionValue.No:
                    JsonSerializer.Serialize(writer, "no", options);
                    return;
                case VriAssertionValue.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriAssertionValue.Unknown:
                    JsonSerializer.Serialize(writer, "unknown", options);
                    return;
                case VriAssertionValue.Yes:
                    JsonSerializer.Serialize(writer, "yes", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriAssertionValue");
        }

        public static readonly VriAssertionValueConverter Singleton = new VriAssertionValueConverter();
    }

    internal class VriVoterClassificationTypeConverter : JsonConverter<VriVoterClassificationType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterClassificationType);

        public override VriVoterClassificationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "activated-national-guard":
                    return VriVoterClassificationType.ActivatedNationalGuard;
                case "active-duty":
                    return VriVoterClassificationType.ActiveDuty;
                case "active-duty-spouse-or-dependent":
                    return VriVoterClassificationType.ActiveDutySpouseOrDependent;
                case "citizen-abroad-intent-to-return":
                    return VriVoterClassificationType.CitizenAbroadIntentToReturn;
                case "citizen-abroad-never-resided":
                    return VriVoterClassificationType.CitizenAbroadNeverResided;
                case "citizen-abroad-return-uncertain":
                    return VriVoterClassificationType.CitizenAbroadReturnUncertain;
                case "deceased":
                    return VriVoterClassificationType.Deceased;
                case "declared-incompetent":
                    return VriVoterClassificationType.DeclaredIncompetent;
                case "eighteen-on-election-day":
                    return VriVoterClassificationType.EighteenOnElectionDay;
                case "felon":
                    return VriVoterClassificationType.Felon;
                case "other":
                    return VriVoterClassificationType.Other;
                case "permanently-denied":
                    return VriVoterClassificationType.PermanentlyDenied;
                case "protected-voter":
                    return VriVoterClassificationType.ProtectedVoter;
                case "restored-felon":
                    return VriVoterClassificationType.RestoredFelon;
                case "united-states-citizen":
                    return VriVoterClassificationType.UnitedStatesCitizen;
            }
            throw new Exception("Cannot unmarshal type VriVoterClassificationType");
        }

        public override void Write(Utf8JsonWriter writer, VriVoterClassificationType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriVoterClassificationType.ActivatedNationalGuard:
                    JsonSerializer.Serialize(writer, "activated-national-guard", options);
                    return;
                case VriVoterClassificationType.ActiveDuty:
                    JsonSerializer.Serialize(writer, "active-duty", options);
                    return;
                case VriVoterClassificationType.ActiveDutySpouseOrDependent:
                    JsonSerializer.Serialize(writer, "active-duty-spouse-or-dependent", options);
                    return;
                case VriVoterClassificationType.CitizenAbroadIntentToReturn:
                    JsonSerializer.Serialize(writer, "citizen-abroad-intent-to-return", options);
                    return;
                case VriVoterClassificationType.CitizenAbroadNeverResided:
                    JsonSerializer.Serialize(writer, "citizen-abroad-never-resided", options);
                    return;
                case VriVoterClassificationType.CitizenAbroadReturnUncertain:
                    JsonSerializer.Serialize(writer, "citizen-abroad-return-uncertain", options);
                    return;
                case VriVoterClassificationType.Deceased:
                    JsonSerializer.Serialize(writer, "deceased", options);
                    return;
                case VriVoterClassificationType.DeclaredIncompetent:
                    JsonSerializer.Serialize(writer, "declared-incompetent", options);
                    return;
                case VriVoterClassificationType.EighteenOnElectionDay:
                    JsonSerializer.Serialize(writer, "eighteen-on-election-day", options);
                    return;
                case VriVoterClassificationType.Felon:
                    JsonSerializer.Serialize(writer, "felon", options);
                    return;
                case VriVoterClassificationType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriVoterClassificationType.PermanentlyDenied:
                    JsonSerializer.Serialize(writer, "permanently-denied", options);
                    return;
                case VriVoterClassificationType.ProtectedVoter:
                    JsonSerializer.Serialize(writer, "protected-voter", options);
                    return;
                case VriVoterClassificationType.RestoredFelon:
                    JsonSerializer.Serialize(writer, "restored-felon", options);
                    return;
                case VriVoterClassificationType.UnitedStatesCitizen:
                    JsonSerializer.Serialize(writer, "united-states-citizen", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterClassificationType");
        }

        public static readonly VriVoterClassificationTypeConverter Singleton = new VriVoterClassificationTypeConverter();
    }

    internal class VoterIdTypeConverter : JsonConverter<VoterIdType>
    {
        public override bool CanConvert(Type t) => t == typeof(VoterIdType);

        public override VoterIdType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.VoterId")
            {
                return VoterIdType.VriVoterId;
            }
            throw new Exception("Cannot unmarshal type VoterIdType");
        }

        public override void Write(Utf8JsonWriter writer, VoterIdType value, JsonSerializerOptions options)
        {
            if (value == VoterIdType.VriVoterId)
            {
                JsonSerializer.Serialize(writer, "VRI.VoterId", options);
                return;
            }
            throw new Exception("Cannot marshal type VoterIdType");
        }

        public static readonly VoterIdTypeConverter Singleton = new VoterIdTypeConverter();
    }

    internal class VriVoterIdTypeConverter : JsonConverter<VriVoterIdType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterIdType);

        public override VriVoterIdType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "drivers-license":
                    return VriVoterIdType.DriversLicense;
                case "local-voter-registration-id":
                    return VriVoterIdType.LocalVoterRegistrationId;
                case "other":
                    return VriVoterIdType.Other;
                case "ssn":
                    return VriVoterIdType.Ssn;
                case "ssn4":
                    return VriVoterIdType.Ssn4;
                case "state-id":
                    return VriVoterIdType.StateId;
                case "state-voter-registration-id":
                    return VriVoterIdType.StateVoterRegistrationId;
                case "unknown":
                    return VriVoterIdType.Unknown;
                case "unspecified-document":
                    return VriVoterIdType.UnspecifiedDocument;
                case "unspecified-document-with-name-and-address":
                    return VriVoterIdType.UnspecifiedDocumentWithNameAndAddress;
                case "unspecified-document-with-photo-identification":
                    return VriVoterIdType.UnspecifiedDocumentWithPhotoIdentification;
            }
            throw new Exception("Cannot unmarshal type VriVoterIdType");
        }

        public override void Write(Utf8JsonWriter writer, VriVoterIdType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriVoterIdType.DriversLicense:
                    JsonSerializer.Serialize(writer, "drivers-license", options);
                    return;
                case VriVoterIdType.LocalVoterRegistrationId:
                    JsonSerializer.Serialize(writer, "local-voter-registration-id", options);
                    return;
                case VriVoterIdType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriVoterIdType.Ssn:
                    JsonSerializer.Serialize(writer, "ssn", options);
                    return;
                case VriVoterIdType.Ssn4:
                    JsonSerializer.Serialize(writer, "ssn4", options);
                    return;
                case VriVoterIdType.StateId:
                    JsonSerializer.Serialize(writer, "state-id", options);
                    return;
                case VriVoterIdType.StateVoterRegistrationId:
                    JsonSerializer.Serialize(writer, "state-voter-registration-id", options);
                    return;
                case VriVoterIdType.Unknown:
                    JsonSerializer.Serialize(writer, "unknown", options);
                    return;
                case VriVoterIdType.UnspecifiedDocument:
                    JsonSerializer.Serialize(writer, "unspecified-document", options);
                    return;
                case VriVoterIdType.UnspecifiedDocumentWithNameAndAddress:
                    JsonSerializer.Serialize(writer, "unspecified-document-with-name-and-address", options);
                    return;
                case VriVoterIdType.UnspecifiedDocumentWithPhotoIdentification:
                    JsonSerializer.Serialize(writer, "unspecified-document-with-photo-identification", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterIdType");
        }

        public static readonly VriVoterIdTypeConverter Singleton = new VriVoterIdTypeConverter();
    }

    internal class VriVoterRequestTypeConverter : JsonConverter<VriVoterRequestType>
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterRequestType);

        public override VriVoterRequestType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ballot-request":
                    return VriVoterRequestType.BallotRequest;
                case "lookup":
                    return VriVoterRequestType.Lookup;
                case "other":
                    return VriVoterRequestType.Other;
                case "registration":
                    return VriVoterRequestType.Registration;
            }
            throw new Exception("Cannot unmarshal type VriVoterRequestType");
        }

        public override void Write(Utf8JsonWriter writer, VriVoterRequestType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriVoterRequestType.BallotRequest:
                    JsonSerializer.Serialize(writer, "ballot-request", options);
                    return;
                case VriVoterRequestType.Lookup:
                    JsonSerializer.Serialize(writer, "lookup", options);
                    return;
                case VriVoterRequestType.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case VriVoterRequestType.Registration:
                    JsonSerializer.Serialize(writer, "registration", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterRequestType");
        }

        public static readonly VriVoterRequestTypeConverter Singleton = new VriVoterRequestTypeConverter();
    }

    internal class VoterRecordTypeConverter : JsonConverter<VoterRecordType>
    {
        public override bool CanConvert(Type t) => t == typeof(VoterRecordType);

        public override VoterRecordType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.VoterRecord")
            {
                return VoterRecordType.VriVoterRecord;
            }
            throw new Exception("Cannot unmarshal type VoterRecordType");
        }

        public override void Write(Utf8JsonWriter writer, VoterRecordType value, JsonSerializerOptions options)
        {
            if (value == VoterRecordType.VriVoterRecord)
            {
                JsonSerializer.Serialize(writer, "VRI.VoterRecord", options);
                return;
            }
            throw new Exception("Cannot marshal type VoterRecordType");
        }

        public static readonly VoterRecordTypeConverter Singleton = new VoterRecordTypeConverter();
    }

    internal class VoterParticipationTypeConverter : JsonConverter<VoterParticipationType>
    {
        public override bool CanConvert(Type t) => t == typeof(VoterParticipationType);

        public override VoterParticipationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.VoterParticipation")
            {
                return VoterParticipationType.VriVoterParticipation;
            }
            throw new Exception("Cannot unmarshal type VoterParticipationType");
        }

        public override void Write(Utf8JsonWriter writer, VoterParticipationType value, JsonSerializerOptions options)
        {
            if (value == VoterParticipationType.VriVoterParticipation)
            {
                JsonSerializer.Serialize(writer, "VRI.VoterParticipation", options);
                return;
            }
            throw new Exception("Cannot marshal type VoterParticipationType");
        }

        public static readonly VoterParticipationTypeConverter Singleton = new VoterParticipationTypeConverter();
    }

    internal class BallotStyleTypeConverter : JsonConverter<BallotStyleType>
    {
        public override bool CanConvert(Type t) => t == typeof(BallotStyleType);

        public override BallotStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "VRI.BallotStyle")
            {
                return BallotStyleType.VriBallotStyle;
            }
            throw new Exception("Cannot unmarshal type BallotStyleType");
        }

        public override void Write(Utf8JsonWriter writer, BallotStyleType value, JsonSerializerOptions options)
        {
            if (value == BallotStyleType.VriBallotStyle)
            {
                JsonSerializer.Serialize(writer, "VRI.BallotStyle", options);
                return;
            }
            throw new Exception("Cannot marshal type BallotStyleType");
        }

        public static readonly BallotStyleTypeConverter Singleton = new BallotStyleTypeConverter();
    }

    internal class VriVoterStatusConverter : JsonConverter<VriVoterStatus>
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterStatus);

        public override VriVoterStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "active":
                    return VriVoterStatus.Active;
                case "inactive":
                    return VriVoterStatus.Inactive;
                case "other":
                    return VriVoterStatus.Other;
            }
            throw new Exception("Cannot unmarshal type VriVoterStatus");
        }

        public override void Write(Utf8JsonWriter writer, VriVoterStatus value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case VriVoterStatus.Active:
                    JsonSerializer.Serialize(writer, "active", options);
                    return;
                case VriVoterStatus.Inactive:
                    JsonSerializer.Serialize(writer, "inactive", options);
                    return;
                case VriVoterStatus.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterStatus");
        }

        public static readonly VriVoterStatusConverter Singleton = new VriVoterStatusConverter();
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603


