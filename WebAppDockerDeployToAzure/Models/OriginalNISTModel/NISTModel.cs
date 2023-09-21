namespace WebAppDockerDeployToAzure.Models.OriginalNISTModel
{

    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NISTModel
    {
        [JsonProperty("@type")]
        public CoordinateType Type { get; set; }

        [JsonProperty("AdditionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public VriAdditionalInfo[] AdditionalInfo { get; set; }

        [JsonProperty("BallotRequest", NullValueHandling = NullValueHandling.Ignore)]
        public VriBallotRequest BallotRequest { get; set; }

        [JsonProperty("Form", NullValueHandling = NullValueHandling.Ignore)]
        public VriRequestForm? Form { get; set; }

        [JsonProperty("GeneratedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GeneratedDate { get; set; }

        [JsonProperty("Issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        [JsonProperty("OtherForm", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherForm { get; set; }

        [JsonProperty("OtherRequestMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherRequestMethod { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("RequestHelper", NullValueHandling = NullValueHandling.Ignore)]
        public VriRequestHelper[] RequestHelper { get; set; }

        [JsonProperty("RequestMethod", NullValueHandling = NullValueHandling.Ignore)]
        public VriRequestMethod? RequestMethod { get; set; }

        [JsonProperty("RequestProxy", NullValueHandling = NullValueHandling.Ignore)]
        public VriRequestProxy RequestProxy { get; set; }

        [JsonProperty("SelectedLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedLanguage { get; set; }

        [JsonProperty("Subject", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoter Subject { get; set; }

        [JsonProperty("TransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterRequestType[] CoordinateType { get; set; }

        [JsonProperty("VendorApplicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorApplicationId { get; set; }

        [JsonProperty("AdditionalDetails", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AdditionalDetails { get; set; }

        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public VriError[] Error { get; set; }

        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public VriSuccessAction[] Action { get; set; }

        [JsonProperty("District", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit[] District { get; set; }

        [JsonProperty("EffectiveDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EffectiveDate { get; set; }

        [JsonProperty("ElectionAdministration", NullValueHandling = NullValueHandling.Ignore)]
        public VriElectionAdministration ElectionAdministration { get; set; }

        [JsonProperty("Locality", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit[] Locality { get; set; }

        [JsonProperty("PollingPlace", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit PollingPlace { get; set; }

        [JsonProperty("VoterRecord", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterRecord[] VoterRecord { get; set; }
    }

    public partial class VriAdditionalInfo
    {
        [JsonProperty("@type")]
        public AdditionalInfoType Type { get; set; }

        [JsonProperty("FileValue", NullValueHandling = NullValueHandling.Ignore)]
        public Vri FileValue { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("StringValue", NullValueHandling = NullValueHandling.Ignore)]
        public string StringValue { get; set; }
    }

    public partial class Vri
    {
        [JsonProperty("@type")]
        public PurpleType Type { get; set; }

        [JsonProperty("Data")]
        public string Data { get; set; }

        [JsonProperty("FileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("MimeType", NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }
    }

    public partial class VriBallotRequest
    {
        [JsonProperty("@type")]
        public BallotRequestType Type { get; set; }

        [JsonProperty("BallotReceiptPreference", NullValueHandling = NullValueHandling.Ignore)]
        public VriBallotReceiptMethod[] BallotReceiptPreference { get; set; }

        [JsonProperty("Election", NullValueHandling = NullValueHandling.Ignore)]
        public VriElection Election { get; set; }

        [JsonProperty("MailForwardingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress MailForwardingAddress { get; set; }

        [JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("StartDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }
    }

    public partial class VriElection
    {
        [JsonProperty("@type")]
        public ElectionType Type { get; set; }

        [JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("ExternalIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public VriExternalIdentifier[] ExternalIdentifier { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("StartDate")]
        public DateTimeOffset StartDate { get; set; }
    }

    public partial class VriExternalIdentifier
    {
        [JsonProperty("@type")]
        public ExternalIdentifierType Type { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Type")]
        public VriIdentifierType VriExternalIdentifierType { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class VriAddress
    {
        [JsonProperty("@type")]
        public VriAddressType Type { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeActionType? Action { get; set; }

        [JsonProperty("AddressAnomalyStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressAnomalyStatus { get; set; }

        [JsonProperty("AddressAuthority", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressAuthority { get; set; }

        [JsonProperty("AddressClassification", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressClassificationType? AddressClassification { get; set; }

        [JsonProperty("AddressCoordinateReferenceSystem", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressCoordinateReferenceSystemType AddressCoordinateReferenceSystem { get; set; }

        [JsonProperty("AddressElevation", NullValueHandling = NullValueHandling.Ignore)]
        public double? AddressElevation { get; set; }

        [JsonProperty("AddressEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AddressEndDate { get; set; }

        [JsonProperty("AddressFeatureType", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AddressFeatureType { get; set; }

        [JsonProperty("AddressId", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressId { get; set; }

        [JsonProperty("AddressLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? AddressLatitude { get; set; }

        [JsonProperty("AddressLifecycleStatus", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressLifecycleStatusType? AddressLifecycleStatus { get; set; }

        [JsonProperty("AddressLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? AddressLongitude { get; set; }

        [JsonProperty("AddressParcelIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AddressParcelIdentifier { get; set; }

        [JsonProperty("AddressParcelIdentifierSource", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AddressParcelIdentifierSource { get; set; }

        [JsonProperty("AddressRangeDirectionality", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressRangeDirectionalityType[] AddressRangeDirectionality { get; set; }

        [JsonProperty("AddressRangeParity", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressRangeParityType[] AddressRangeParity { get; set; }

        [JsonProperty("AddressRangeSpan", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressRangeSpanType[] AddressRangeSpan { get; set; }

        [JsonProperty("AddressRangeType", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressRangeTypeType[] AddressRangeType { get; set; }

        [JsonProperty("AddressReferenceSystemAuthority", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressReferenceSystemAuthority { get; set; }

        [JsonProperty("AddressReferenceSystemId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AddressReferenceSystemId { get; set; }

        [JsonProperty("AddressSideOfStreet", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressSideOfStreetType? AddressSideOfStreet { get; set; }

        [JsonProperty("AddressStartDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AddressStartDate { get; set; }

        [JsonProperty("AddressTransportationFeatureID", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTransportationFeatureId { get; set; }

        [JsonProperty("AddressTransportationFeatureType", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTransportationFeatureType { get; set; }

        [JsonProperty("AddressTransportationSystemAuthority", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTransportationSystemAuthority { get; set; }

        [JsonProperty("AddressTransportationSystemName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTransportationSystemName { get; set; }

        [JsonProperty("AddressXCoordinate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AddressXCoordinate { get; set; }

        [JsonProperty("AddressYCoordinate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AddressYCoordinate { get; set; }

        [JsonProperty("AddressZLevel", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressZLevel { get; set; }

        [JsonProperty("CompleteAddressNumber", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber { get; set; }

        [JsonProperty("CompleteLandmarkName", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteLandmarkNameType CompleteLandmarkName { get; set; }

        [JsonProperty("CompletePlaceName1", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompletePlaceNameType CompletePlaceName1 { get; set; }

        [JsonProperty("CompletePlaceName2", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompletePlaceNameType CompletePlaceName2 { get; set; }

        [JsonProperty("CompleteSubaddress", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteSubaddressType CompleteSubaddress { get; set; }

        [JsonProperty("CountryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("DataSetID", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSetId { get; set; }

        [JsonProperty("LocationDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationDescription { get; set; }

        [JsonProperty("MailableAddress", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeMailableAddressType? MailableAddress { get; set; }

        [JsonProperty("OfficialStatus", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeOfficialStatusType? OfficialStatus { get; set; }

        [JsonProperty("PlaceStateZip", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PlaceStateZip { get; set; }

        [JsonProperty("RelatedAddressId", NullValueHandling = NullValueHandling.Ignore)]
        public string[] RelatedAddressId { get; set; }

        [JsonProperty("RelatedTransportationFeatureID", NullValueHandling = NullValueHandling.Ignore)]
        public string[] RelatedTransportationFeatureId { get; set; }

        [JsonProperty("StateName", NullValueHandling = NullValueHandling.Ignore)]
        public string StateName { get; set; }

        [JsonProperty("USNationalGridCoordinate", NullValueHandling = NullValueHandling.Ignore)]
        public string UsNationalGridCoordinate { get; set; }

        [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        [JsonProperty("ZipPlus4", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipPlus4 { get; set; }

        [JsonProperty("CompleteAddressNumber1", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber1 { get; set; }

        [JsonProperty("CompleteAddressNumber2", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber2 { get; set; }

        [JsonProperty("CompleteAddressNumber3", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber3 { get; set; }

        [JsonProperty("CompleteAddressNumber4", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber4 { get; set; }

        [JsonProperty("CompleteStreetName", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteStreetNameType CompleteStreetName { get; set; }

        [JsonProperty("SeparatorElement1", NullValueHandling = NullValueHandling.Ignore)]
        public string SeparatorElement1 { get; set; }

        [JsonProperty("SeparatorElement2", NullValueHandling = NullValueHandling.Ignore)]
        public string SeparatorElement2 { get; set; }

        [JsonProperty("CompletePlaceName", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompletePlaceNameType CompletePlaceName { get; set; }

        [JsonProperty("GeneralAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneralAddress { get; set; }

        [JsonProperty("USPSGeneralDeliveryPoint", NullValueHandling = NullValueHandling.Ignore)]
        public string UspsGeneralDeliveryPoint { get; set; }

        [JsonProperty("CompleteStreetName1", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteStreetNameType CompleteStreetName1 { get; set; }

        [JsonProperty("CompleteStreetName2", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteStreetNameType CompleteStreetName2 { get; set; }

        [JsonProperty("CornerOf", NullValueHandling = NullValueHandling.Ignore)]
        public string CornerOf { get; set; }

        [JsonProperty("SeparatorElement", NullValueHandling = NullValueHandling.Ignore)]
        public string SeparatorElement { get; set; }

        [JsonProperty("USPSBox", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeUspsBoxType UspsBox { get; set; }

        [JsonProperty("USPSAddress", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeUspsAddressType UspsAddress { get; set; }
    }

    public partial class AddrTypeAddressCoordinateReferenceSystemType
    {
        [JsonProperty("@type")]
        public AddressCoordinateReferenceSystemType Type { get; set; }

        [JsonProperty("AddressCoordinateReferenceSystemAuthority")]
        public string AddressCoordinateReferenceSystemAuthority { get; set; }

        [JsonProperty("AddressCoordinateReferenceSystemID")]
        public long AddressCoordinateReferenceSystemId { get; set; }
    }

    public partial class AddrTypeCompleteAddressNumberType
    {
        [JsonProperty("@type")]
        public CompleteAddressNumberType Type { get; set; }

        [JsonProperty("AddressNumber")]
        public string AddressNumber { get; set; }

        [JsonProperty("AddressNumberParity", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressNumberParityType? AddressNumberParity { get; set; }

        [JsonProperty("AddressNumberPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressNumberPrefixType AddressNumberPrefix { get; set; }

        [JsonProperty("AddressNumberSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAddressNumberSuffixType AddressNumberSuffix { get; set; }

        [JsonProperty("AttachedElement", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAttachedElementType? AttachedElement { get; set; }
    }

    public partial class AddrTypeAddressNumberPrefixType
    {
        [JsonProperty("@type")]
        public AddressNumberPrefixType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeAddressNumberSuffixType
    {
        [JsonProperty("@type")]
        public AddressNumberSuffixType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteLandmarkNameType
    {
        [JsonProperty("@type")]
        public CompleteLandmarkNameType Type { get; set; }

        [JsonProperty("LandmarkName")]
        public AddrTypeLandmarkNameType[] LandmarkName { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }
    }

    public partial class AddrTypeLandmarkNameType
    {
        [JsonProperty("@type")]
        public LandmarkNameType Type { get; set; }

        [JsonProperty("ElementSequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? ElementSequenceNumber { get; set; }

        [JsonProperty("GNISFeatureID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GnisFeatureId { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompletePlaceNameType
    {
        [JsonProperty("@type")]
        public CompletePlaceNameType Type { get; set; }

        [JsonProperty("PlaceName")]
        public AddrTypePlaceNameType[] PlaceName { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }
    }

    public partial class AddrTypePlaceNameType
    {
        [JsonProperty("@type")]
        public PlaceNameType Type { get; set; }

        [JsonProperty("ElementSequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? ElementSequenceNumber { get; set; }

        [JsonProperty("GNISFeatureID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GnisFeatureId { get; set; }

        [JsonProperty("PlaceNameType", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypePlaceNameTypeType? PlaceNameType { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteStreetNameType
    {
        [JsonProperty("@type")]
        public CompleteStreetNameType Type { get; set; }

        [JsonProperty("AttachedElement", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeAttachedElementType? AttachedElement { get; set; }

        [JsonProperty("StreetName")]
        public string StreetName { get; set; }

        [JsonProperty("StreetNamePostDirectional", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreDirectionalType StreetNamePostDirectional { get; set; }

        [JsonProperty("StreetNamePostModifier", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreModifierType StreetNamePostModifier { get; set; }

        [JsonProperty("StreetNamePostType", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreTypeType StreetNamePostType { get; set; }

        [JsonProperty("StreetNamePreDirectional", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreDirectionalType StreetNamePreDirectional { get; set; }

        [JsonProperty("StreetNamePreModifier", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreModifierType StreetNamePreModifier { get; set; }

        [JsonProperty("StreetNamePreType", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreTypeType StreetNamePreType { get; set; }
    }

    public partial class AddrTypeStreetNamePreDirectionalType
    {
        [JsonProperty("@type")]
        public StreetNamePostDirectionalType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeStreetNamePreModifierType
    {
        [JsonProperty("@type")]
        public StreetNamePostModifierType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeStreetNamePreTypeType
    {
        [JsonProperty("@type")]
        public StreetNamePostTypeType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteSubaddressType
    {
        [JsonProperty("@type")]
        public CompleteSubaddressType Type { get; set; }

        [JsonProperty("SubaddressElement")]
        public AddrTypeSubaddressElementType[] SubaddressElement { get; set; }
    }

    public partial class AddrTypeSubaddressElementType
    {
        [JsonProperty("@type")]
        public SubaddressElementType Type { get; set; }

        [JsonProperty("ElementSequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? ElementSequenceNumber { get; set; }

        [JsonProperty("GNISFeatureID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GnisFeatureId { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("SubaddressComponentOrder", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeSubaddressComponentOrderType? SubaddressComponentOrder { get; set; }

        [JsonProperty("SubaddressIdentifier")]
        public string SubaddressIdentifier { get; set; }

        [JsonProperty("SubaddressType", NullValueHandling = NullValueHandling.Ignore)]
        public string SubaddressType { get; set; }
    }

    public partial class AddrTypeUspsAddressType
    {
        [JsonProperty("@type")]
        public UspsAddressType Type { get; set; }

        [JsonProperty("USPSBox")]
        public AddrTypeUspsBoxType UspsBox { get; set; }

        [JsonProperty("USPSRoute")]
        public AddrTypeUspsRouteType UspsRoute { get; set; }
    }

    public partial class AddrTypeUspsBoxType
    {
        [JsonProperty("@type")]
        public UspsBoxType Type { get; set; }

        [JsonProperty("USPSBoxId")]
        public string UspsBoxId { get; set; }

        [JsonProperty("USPSBoxType")]
        public string UspsBoxType { get; set; }
    }

    public partial class AddrTypeUspsRouteType
    {
        [JsonProperty("@type")]
        public UspsRouteType Type { get; set; }

        [JsonProperty("USPSBoxGroupId")]
        public string UspsBoxGroupId { get; set; }

        [JsonProperty("USPSBoxGroupType")]
        public string UspsBoxGroupType { get; set; }
    }

    public partial class VriReportingUnit
    {
        [JsonProperty("@type")]
        public PollingPlaceType Type { get; set; }

        [JsonProperty("ExternalIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public VriExternalIdentifier[] ExternalIdentifier { get; set; }

        [JsonProperty("IsDistricted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDistricted { get; set; }

        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public VriLocation Location { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Type")]
        public VriReportingUnitType VriReportingUnitType { get; set; }
    }

    public partial class VriLocation
    {
        [JsonProperty("@type")]
        public LocationType Type { get; set; }

        [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress Address { get; set; }

        [JsonProperty("Directions", NullValueHandling = NullValueHandling.Ignore)]
        public string Directions { get; set; }

        [JsonProperty("LatLng", NullValueHandling = NullValueHandling.Ignore)]
        public VriLatLng LatLng { get; set; }
    }

    public partial class VriLatLng
    {
        [JsonProperty("@type")]
        public LatLngType Type { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }
    }

    public partial class VriElectionAdministration
    {
        [JsonProperty("@type")]
        public ElectionAdministrationType Type { get; set; }

        [JsonProperty("ContactMethod", NullValueHandling = NullValueHandling.Ignore)]
        public VriContactMethod[] ContactMethod { get; set; }

        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public VriLocation Location { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("Uri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[] Uri { get; set; }
    }

    public partial class VriContactMethod
    {
        [JsonProperty("@type")]
        public ContactMethodType Type { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Type")]
        public VriContactMethodType VriContactMethodType { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("Capability", NullValueHandling = NullValueHandling.Ignore)]
        public VriPhoneCapability[] Capability { get; set; }
    }

    public partial class VriError
    {
        [JsonProperty("@type")]
        public ErrorType Type { get; set; }

        [JsonProperty("Name")]
        public VriRequestError Name { get; set; }

        [JsonProperty("OtherError", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherError { get; set; }

        [JsonProperty("Ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }
    }

    public partial class VriRequestHelper
    {
        [JsonProperty("@type")]
        public RequestHelperType Type { get; set; }

        [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress Address { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public VriName Name { get; set; }

        [JsonProperty("Phone", NullValueHandling = NullValueHandling.Ignore)]
        public VriPhoneContactMethod Phone { get; set; }

        [JsonProperty("Signature", NullValueHandling = NullValueHandling.Ignore)]
        public VriSignature Signature { get; set; }

        [JsonProperty("Type")]
        public VriVoterHelperType VriRequestHelperType { get; set; }
    }

    public partial class VriName
    {
        [JsonProperty("@type")]
        public NameType Type { get; set; }

        [JsonProperty("FirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("FullName", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [JsonProperty("LastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("MiddleName", NullValueHandling = NullValueHandling.Ignore)]
        public string[] MiddleName { get; set; }

        [JsonProperty("Prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        [JsonProperty("Suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }
    }

    public partial class VriPhoneContactMethod
    {
        [JsonProperty("@type")]
        public PhoneType Type { get; set; }

        [JsonProperty("Capability", NullValueHandling = NullValueHandling.Ignore)]
        public VriPhoneCapability[] Capability { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Type")]
        public VriContactMethodType VriPhoneContactMethodType { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class VriSignature
    {
        [JsonProperty("@type")]
        public PreviousSignatureType Type { get; set; }

        [JsonProperty("Date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("FileValue", NullValueHandling = NullValueHandling.Ignore)]
        public VriImage FileValue { get; set; }

        [JsonProperty("OtherSource", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherSource { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Source", NullValueHandling = NullValueHandling.Ignore)]
        public VriSignatureSource? Source { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public VriSignatureType? VriSignatureType { get; set; }
    }

    public partial class VriImage
    {
        [JsonProperty("@type")]
        public FluffyType Type { get; set; }

        [JsonProperty("Data")]
        public string Data { get; set; }

        [JsonProperty("FileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("MimeType", NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }
    }

    public partial class VriRequestProxy
    {
        [JsonProperty("@type")]
        public RequestProxyType Type { get; set; }

        [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress Address { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("OriginTransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginTransactionId { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Phone", NullValueHandling = NullValueHandling.Ignore)]
        public VriPhoneContactMethod Phone { get; set; }

        [JsonProperty("TimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TimeStamp { get; set; }

        [JsonProperty("Type")]
        public VriRequestProxyType VriRequestProxyType { get; set; }
    }

    public partial class VriVoter
    {
        [JsonProperty("@type")]
        public SubjectType Type { get; set; }

        [JsonProperty("ContactMethod", NullValueHandling = NullValueHandling.Ignore)]
        public VriContactMethod[] ContactMethod { get; set; }

        [JsonProperty("DateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfBirth { get; set; }

        [JsonProperty("Ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethnicity { get; set; }

        [JsonProperty("Gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [JsonProperty("MailingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress MailingAddress { get; set; }

        [JsonProperty("Name")]
        public VriName Name { get; set; }

        [JsonProperty("Party", NullValueHandling = NullValueHandling.Ignore)]
        public VriParty Party { get; set; }

        [JsonProperty("PreviousName", NullValueHandling = NullValueHandling.Ignore)]
        public VriName PreviousName { get; set; }

        [JsonProperty("PreviousResidenceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public VriAddress PreviousResidenceAddress { get; set; }

        [JsonProperty("PreviousSignature", NullValueHandling = NullValueHandling.Ignore)]
        public VriSignature PreviousSignature { get; set; }

        [JsonProperty("ResidenceAddress")]
        public VriAddress ResidenceAddress { get; set; }

        [JsonProperty("ResidenceAddressIsMailingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResidenceAddressIsMailingAddress { get; set; }

        [JsonProperty("Signature", NullValueHandling = NullValueHandling.Ignore)]
        public VriSignature Signature { get; set; }

        [JsonProperty("VoterClassification", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterClassification[] VoterClassification { get; set; }

        [JsonProperty("VoterId", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterId[] VoterId { get; set; }
    }

    public partial class VriParty
    {
        [JsonProperty("@type")]
        public PartyType Type { get; set; }

        [JsonProperty("Abbreviation", NullValueHandling = NullValueHandling.Ignore)]
        public string Abbreviation { get; set; }

        [JsonProperty("ExternalIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public VriExternalIdentifier[] ExternalIdentifier { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class VriVoterClassification
    {
        [JsonProperty("@type")]
        public VoterClassificationType Type { get; set; }

        [JsonProperty("Assertion")]
        public VriAssertionValue Assertion { get; set; }

        [JsonProperty("OtherAssertion", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherAssertion { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("Type")]
        public VriVoterClassificationType VriVoterClassificationType { get; set; }
    }

    public partial class VriVoterId
    {
        [JsonProperty("@type")]
        public VoterIdType Type { get; set; }

        [JsonProperty("AttestNoSuchId", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttestNoSuchId { get; set; }

        [JsonProperty("DateOfIssuance", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfIssuance { get; set; }

        [JsonProperty("FileValue", NullValueHandling = NullValueHandling.Ignore)]
        public Vri FileValue { get; set; }

        [JsonProperty("OtherType", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [JsonProperty("StringValue", NullValueHandling = NullValueHandling.Ignore)]
        public string StringValue { get; set; }

        [JsonProperty("Type")]
        public VriVoterIdType VriVoterIdType { get; set; }
    }

    public partial class VriVoterRecord
    {
        [JsonProperty("@type")]
        public VoterRecordType Type { get; set; }

        [JsonProperty("District", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit[] District { get; set; }

        [JsonProperty("ElectionAdministration", NullValueHandling = NullValueHandling.Ignore)]
        public VriElectionAdministration ElectionAdministration { get; set; }

        [JsonProperty("HavaIdRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HavaIdRequired { get; set; }

        [JsonProperty("Locality", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit[] Locality { get; set; }

        [JsonProperty("OtherStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherStatus { get; set; }

        [JsonProperty("PollingLocation", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit PollingLocation { get; set; }

        [JsonProperty("Voter")]
        public VriVoter Voter { get; set; }

        [JsonProperty("VoterParticipation", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterParticipation[] VoterParticipation { get; set; }

        [JsonProperty("VoterStatus", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterStatus? VoterStatus { get; set; }
    }

    public partial class VriVoterParticipation
    {
        [JsonProperty("@type")]
        public VoterParticipationType Type { get; set; }

        [JsonProperty("BallotStyle", NullValueHandling = NullValueHandling.Ignore)]
        public VriBallotStyle BallotStyle { get; set; }

        [JsonProperty("Election")]
        public VriElection Election { get; set; }

        [JsonProperty("PollingLocation", NullValueHandling = NullValueHandling.Ignore)]
        public VriReportingUnit PollingLocation { get; set; }
    }

    public partial class VriBallotStyle
    {
        [JsonProperty("@type")]
        public BallotStyleType Type { get; set; }

        [JsonProperty("ExternalIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public VriExternalIdentifier[] ExternalIdentifier { get; set; }

        [JsonProperty("ImageUri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[] ImageUri { get; set; }

        [JsonProperty("Party", NullValueHandling = NullValueHandling.Ignore)]
        public VriParty[] Party { get; set; }
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
        public static Coordinate FromJson(string json) => JsonConvert.DeserializeObject<Coordinate>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this Coordinate self) => JsonConvert.SerializeObject(self);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
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
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CoordinateTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CoordinateType) || t == typeof(CoordinateType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CoordinateType)untypedValue;
            switch (value)
            {
                case CoordinateType.VriRequestAcknowledgement:
                    serializer.Serialize(writer, "VRI.RequestAcknowledgement");
                    return;
                case CoordinateType.VriRequestRejection:
                    serializer.Serialize(writer, "VRI.RequestRejection");
                    return;
                case CoordinateType.VriRequestSuccess:
                    serializer.Serialize(writer, "VRI.RequestSuccess");
                    return;
                case CoordinateType.VriVoterRecordResults:
                    serializer.Serialize(writer, "VRI.VoterRecordResults");
                    return;
                case CoordinateType.VriVoterRecordsRequest:
                    serializer.Serialize(writer, "VRI.VoterRecordsRequest");
                    return;
            }
            throw new Exception("Cannot marshal type CoordinateType");
        }

        public static readonly CoordinateTypeConverter Singleton = new CoordinateTypeConverter();
    }

    internal class VriSuccessActionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriSuccessAction) || t == typeof(VriSuccessAction?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriSuccessAction)untypedValue;
            switch (value)
            {
                case VriSuccessAction.AddressUpdated:
                    serializer.Serialize(writer, "address-updated");
                    return;
                case VriSuccessAction.NameUpdated:
                    serializer.Serialize(writer, "name-updated");
                    return;
                case VriSuccessAction.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriSuccessAction.RegistrationCancelled:
                    serializer.Serialize(writer, "registration-cancelled");
                    return;
                case VriSuccessAction.RegistrationCreated:
                    serializer.Serialize(writer, "registration-created");
                    return;
                case VriSuccessAction.RegistrationUpdated:
                    serializer.Serialize(writer, "registration-updated");
                    return;
                case VriSuccessAction.StatusUpdated:
                    serializer.Serialize(writer, "status-updated");
                    return;
            }
            throw new Exception("Cannot marshal type VriSuccessAction");
        }

        public static readonly VriSuccessActionConverter Singleton = new VriSuccessActionConverter();
    }

    internal class AdditionalInfoTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AdditionalInfoType) || t == typeof(AdditionalInfoType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.AdditionalInfo")
            {
                return AdditionalInfoType.VriAdditionalInfo;
            }
            throw new Exception("Cannot unmarshal type AdditionalInfoType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AdditionalInfoType)untypedValue;
            if (value == AdditionalInfoType.VriAdditionalInfo)
            {
                serializer.Serialize(writer, "VRI.AdditionalInfo");
                return;
            }
            throw new Exception("Cannot marshal type AdditionalInfoType");
        }

        public static readonly AdditionalInfoTypeConverter Singleton = new AdditionalInfoTypeConverter();
    }

    internal class PurpleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleType) || t == typeof(PurpleType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "VRI.File":
                    return PurpleType.VriFile;
                case "VRI.Image":
                    return PurpleType.VriImage;
            }
            throw new Exception("Cannot unmarshal type PurpleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleType)untypedValue;
            switch (value)
            {
                case PurpleType.VriFile:
                    serializer.Serialize(writer, "VRI.File");
                    return;
                case PurpleType.VriImage:
                    serializer.Serialize(writer, "VRI.Image");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleType");
        }

        public static readonly PurpleTypeConverter Singleton = new PurpleTypeConverter();
    }

    internal class BallotRequestTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BallotRequestType) || t == typeof(BallotRequestType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BallotRequestType)untypedValue;
            switch (value)
            {
                case BallotRequestType.VriElectionBasedBallotRequest:
                    serializer.Serialize(writer, "VRI.ElectionBasedBallotRequest");
                    return;
                case BallotRequestType.VriPermanentBallotRequest:
                    serializer.Serialize(writer, "VRI.PermanentBallotRequest");
                    return;
                case BallotRequestType.VriTemporalBallotRequest:
                    serializer.Serialize(writer, "VRI.TemporalBallotRequest");
                    return;
            }
            throw new Exception("Cannot marshal type BallotRequestType");
        }

        public static readonly BallotRequestTypeConverter Singleton = new BallotRequestTypeConverter();
    }

    internal class VriBallotReceiptMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriBallotReceiptMethod) || t == typeof(VriBallotReceiptMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriBallotReceiptMethod)untypedValue;
            switch (value)
            {
                case VriBallotReceiptMethod.Email:
                    serializer.Serialize(writer, "email");
                    return;
                case VriBallotReceiptMethod.EmailOrOnline:
                    serializer.Serialize(writer, "email-or-online");
                    return;
                case VriBallotReceiptMethod.Fax:
                    serializer.Serialize(writer, "fax");
                    return;
                case VriBallotReceiptMethod.Mail:
                    serializer.Serialize(writer, "mail");
                    return;
                case VriBallotReceiptMethod.Online:
                    serializer.Serialize(writer, "online");
                    return;
            }
            throw new Exception("Cannot marshal type VriBallotReceiptMethod");
        }

        public static readonly VriBallotReceiptMethodConverter Singleton = new VriBallotReceiptMethodConverter();
    }

    internal class ElectionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ElectionType) || t == typeof(ElectionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Election")
            {
                return ElectionType.VriElection;
            }
            throw new Exception("Cannot unmarshal type ElectionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ElectionType)untypedValue;
            if (value == ElectionType.VriElection)
            {
                serializer.Serialize(writer, "VRI.Election");
                return;
            }
            throw new Exception("Cannot marshal type ElectionType");
        }

        public static readonly ElectionTypeConverter Singleton = new ElectionTypeConverter();
    }

    internal class ExternalIdentifierTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExternalIdentifierType) || t == typeof(ExternalIdentifierType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.ExternalIdentifier")
            {
                return ExternalIdentifierType.VriExternalIdentifier;
            }
            throw new Exception("Cannot unmarshal type ExternalIdentifierType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExternalIdentifierType)untypedValue;
            if (value == ExternalIdentifierType.VriExternalIdentifier)
            {
                serializer.Serialize(writer, "VRI.ExternalIdentifier");
                return;
            }
            throw new Exception("Cannot marshal type ExternalIdentifierType");
        }

        public static readonly ExternalIdentifierTypeConverter Singleton = new ExternalIdentifierTypeConverter();
    }

    internal class VriIdentifierTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriIdentifierType) || t == typeof(VriIdentifierType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriIdentifierType)untypedValue;
            switch (value)
            {
                case VriIdentifierType.Fips:
                    serializer.Serialize(writer, "fips");
                    return;
                case VriIdentifierType.LocalLevel:
                    serializer.Serialize(writer, "local-level");
                    return;
                case VriIdentifierType.NationalLevel:
                    serializer.Serialize(writer, "national-level");
                    return;
                case VriIdentifierType.OcdId:
                    serializer.Serialize(writer, "ocd-id");
                    return;
                case VriIdentifierType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriIdentifierType.StateLevel:
                    serializer.Serialize(writer, "state-level");
                    return;
            }
            throw new Exception("Cannot marshal type VriIdentifierType");
        }

        public static readonly VriIdentifierTypeConverter Singleton = new VriIdentifierTypeConverter();
    }

    internal class VriAddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriAddressType) || t == typeof(VriAddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriAddressType)untypedValue;
            switch (value)
            {
                case VriAddressType.AddrCommunityAddressType:
                    serializer.Serialize(writer, "addr.CommunityAddress_type");
                    return;
                case VriAddressType.AddrFourNumberAddressRangeType:
                    serializer.Serialize(writer, "addr.FourNumberAddressRange_type");
                    return;
                case VriAddressType.AddrGeneralAddressClassType:
                    serializer.Serialize(writer, "addr.GeneralAddressClass_type");
                    return;
                case VriAddressType.AddrIntersectionAddressType:
                    serializer.Serialize(writer, "addr.IntersectionAddress_type");
                    return;
                case VriAddressType.AddrLandmarkAddressType:
                    serializer.Serialize(writer, "addr.LandmarkAddress_type");
                    return;
                case VriAddressType.AddrNumberedThoroughfareAddressType:
                    serializer.Serialize(writer, "addr.NumberedThoroughfareAddress_type");
                    return;
                case VriAddressType.AddrTwoNumberAddressRangeType:
                    serializer.Serialize(writer, "addr.TwoNumberAddressRange_type");
                    return;
                case VriAddressType.AddrUspsGeneralDeliveryOfficeType:
                    serializer.Serialize(writer, "addr.USPSGeneralDeliveryOffice_type");
                    return;
                case VriAddressType.AddrUspsPostalDeliveryBoxType:
                    serializer.Serialize(writer, "addr.USPSPostalDeliveryBox_type");
                    return;
                case VriAddressType.AddrUspsPostalDeliveryRouteType:
                    serializer.Serialize(writer, "addr.USPSPostalDeliveryRoute_type");
                    return;
                case VriAddressType.AddrUnnumberedThoroughfareAddressType:
                    serializer.Serialize(writer, "addr.UnnumberedThoroughfareAddress_type");
                    return;
            }
            throw new Exception("Cannot marshal type VriAddressType");
        }

        public static readonly VriAddressTypeConverter Singleton = new VriAddressTypeConverter();
    }

    internal class AddrTypeAddressClassificationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressClassificationType) || t == typeof(AddrTypeAddressClassificationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressClassificationType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressClassificationType.CommunityAddress:
                    serializer.Serialize(writer, "CommunityAddress");
                    return;
                case AddrTypeAddressClassificationType.FourNumberAddressRange:
                    serializer.Serialize(writer, "FourNumberAddressRange");
                    return;
                case AddrTypeAddressClassificationType.GeneralAddressClass:
                    serializer.Serialize(writer, "GeneralAddressClass");
                    return;
                case AddrTypeAddressClassificationType.IntersectionAddress:
                    serializer.Serialize(writer, "IntersectionAddress");
                    return;
                case AddrTypeAddressClassificationType.LandmarkAddress:
                    serializer.Serialize(writer, "LandmarkAddress");
                    return;
                case AddrTypeAddressClassificationType.NumberedThoroughfareAddress:
                    serializer.Serialize(writer, "NumberedThoroughfareAddress");
                    return;
                case AddrTypeAddressClassificationType.TwoNumberAddressRange:
                    serializer.Serialize(writer, "TwoNumberAddressRange");
                    return;
                case AddrTypeAddressClassificationType.UspsGeneralDeliveryOffice:
                    serializer.Serialize(writer, "USPSGeneral DeliveryOffice");
                    return;
                case AddrTypeAddressClassificationType.UspsPostalDeliveryRoute:
                    serializer.Serialize(writer, "USPSPostal DeliveryRoute");
                    return;
                case AddrTypeAddressClassificationType.UspsPostalDeliveryBox:
                    serializer.Serialize(writer, "USPSPostalDeliveryBox");
                    return;
                case AddrTypeAddressClassificationType.UnnumberedThoroughfareAddress:
                    serializer.Serialize(writer, "UnnumberedThoroughfareAddress");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressClassificationType");
        }

        public static readonly AddrTypeAddressClassificationTypeConverter Singleton = new AddrTypeAddressClassificationTypeConverter();
    }

    internal class AddressCoordinateReferenceSystemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressCoordinateReferenceSystemType) || t == typeof(AddressCoordinateReferenceSystemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.AddressCoordinateReferenceSystem_type")
            {
                return AddressCoordinateReferenceSystemType.AddrTypeAddressCoordinateReferenceSystemType;
            }
            throw new Exception("Cannot unmarshal type AddressCoordinateReferenceSystemType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressCoordinateReferenceSystemType)untypedValue;
            if (value == AddressCoordinateReferenceSystemType.AddrTypeAddressCoordinateReferenceSystemType)
            {
                serializer.Serialize(writer, "addr_type.AddressCoordinateReferenceSystem_type");
                return;
            }
            throw new Exception("Cannot marshal type AddressCoordinateReferenceSystemType");
        }

        public static readonly AddressCoordinateReferenceSystemTypeConverter Singleton = new AddressCoordinateReferenceSystemTypeConverter();
    }

    internal class AddrTypeAddressLifecycleStatusTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressLifecycleStatusType) || t == typeof(AddrTypeAddressLifecycleStatusType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressLifecycleStatusType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressLifecycleStatusType.Active:
                    serializer.Serialize(writer, "Active");
                    return;
                case AddrTypeAddressLifecycleStatusType.Potential:
                    serializer.Serialize(writer, "Potential");
                    return;
                case AddrTypeAddressLifecycleStatusType.Proposed:
                    serializer.Serialize(writer, "Proposed");
                    return;
                case AddrTypeAddressLifecycleStatusType.Retired:
                    serializer.Serialize(writer, "Retired");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressLifecycleStatusType");
        }

        public static readonly AddrTypeAddressLifecycleStatusTypeConverter Singleton = new AddrTypeAddressLifecycleStatusTypeConverter();
    }

    internal class AddrTypeAddressRangeDirectionalityTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeDirectionalityType) || t == typeof(AddrTypeAddressRangeDirectionalityType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressRangeDirectionalityType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressRangeDirectionalityType.Against:
                    serializer.Serialize(writer, "Against");
                    return;
                case AddrTypeAddressRangeDirectionalityType.AgainstWith:
                    serializer.Serialize(writer, "Against-With");
                    return;
                case AddrTypeAddressRangeDirectionalityType.Na:
                    serializer.Serialize(writer, "NA");
                    return;
                case AddrTypeAddressRangeDirectionalityType.Null:
                    serializer.Serialize(writer, "Null");
                    return;
                case AddrTypeAddressRangeDirectionalityType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
                case AddrTypeAddressRangeDirectionalityType.With:
                    serializer.Serialize(writer, "With");
                    return;
                case AddrTypeAddressRangeDirectionalityType.WithAgainst:
                    serializer.Serialize(writer, "With-Against");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeDirectionalityType");
        }

        public static readonly AddrTypeAddressRangeDirectionalityTypeConverter Singleton = new AddrTypeAddressRangeDirectionalityTypeConverter();
    }

    internal class AddrTypeAddressRangeParityTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeParityType) || t == typeof(AddrTypeAddressRangeParityType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressRangeParityType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressRangeParityType.Both:
                    serializer.Serialize(writer, "both");
                    return;
                case AddrTypeAddressRangeParityType.Even:
                    serializer.Serialize(writer, "even");
                    return;
                case AddrTypeAddressRangeParityType.None:
                    serializer.Serialize(writer, "none");
                    return;
                case AddrTypeAddressRangeParityType.Odd:
                    serializer.Serialize(writer, "odd");
                    return;
                case AddrTypeAddressRangeParityType.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeParityType");
        }

        public static readonly AddrTypeAddressRangeParityTypeConverter Singleton = new AddrTypeAddressRangeParityTypeConverter();
    }

    internal class AddrTypeAddressRangeSpanTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeSpanType) || t == typeof(AddrTypeAddressRangeSpanType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressRangeSpanType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressRangeSpanType.EntireStreet:
                    serializer.Serialize(writer, "Entire Street");
                    return;
                case AddrTypeAddressRangeSpanType.MultiSegment:
                    serializer.Serialize(writer, "Multi Segment");
                    return;
                case AddrTypeAddressRangeSpanType.PartialSegment:
                    serializer.Serialize(writer, "Partial Segment");
                    return;
                case AddrTypeAddressRangeSpanType.SingleSegment:
                    serializer.Serialize(writer, "Single Segment");
                    return;
                case AddrTypeAddressRangeSpanType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeSpanType");
        }

        public static readonly AddrTypeAddressRangeSpanTypeConverter Singleton = new AddrTypeAddressRangeSpanTypeConverter();
    }

    internal class AddrTypeAddressRangeTypeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressRangeTypeType) || t == typeof(AddrTypeAddressRangeTypeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressRangeTypeType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressRangeTypeType.Actual:
                    serializer.Serialize(writer, "Actual");
                    return;
                case AddrTypeAddressRangeTypeType.Potential:
                    serializer.Serialize(writer, "Potential");
                    return;
                case AddrTypeAddressRangeTypeType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressRangeTypeType");
        }

        public static readonly AddrTypeAddressRangeTypeTypeConverter Singleton = new AddrTypeAddressRangeTypeTypeConverter();
    }

    internal class AddrTypeAddressSideOfStreetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressSideOfStreetType) || t == typeof(AddrTypeAddressSideOfStreetType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressSideOfStreetType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressSideOfStreetType.Both:
                    serializer.Serialize(writer, "both");
                    return;
                case AddrTypeAddressSideOfStreetType.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case AddrTypeAddressSideOfStreetType.None:
                    serializer.Serialize(writer, "none");
                    return;
                case AddrTypeAddressSideOfStreetType.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case AddrTypeAddressSideOfStreetType.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressSideOfStreetType");
        }

        public static readonly AddrTypeAddressSideOfStreetTypeConverter Singleton = new AddrTypeAddressSideOfStreetTypeConverter();
    }

    internal class CompleteAddressNumberTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteAddressNumberType) || t == typeof(CompleteAddressNumberType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.CompleteAddressNumber_type")
            {
                return CompleteAddressNumberType.AddrTypeCompleteAddressNumberType;
            }
            throw new Exception("Cannot unmarshal type CompleteAddressNumberType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CompleteAddressNumberType)untypedValue;
            if (value == CompleteAddressNumberType.AddrTypeCompleteAddressNumberType)
            {
                serializer.Serialize(writer, "addr_type.CompleteAddressNumber_type");
                return;
            }
            throw new Exception("Cannot marshal type CompleteAddressNumberType");
        }

        public static readonly CompleteAddressNumberTypeConverter Singleton = new CompleteAddressNumberTypeConverter();
    }

    internal class AddrTypeAddressNumberParityTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAddressNumberParityType) || t == typeof(AddrTypeAddressNumberParityType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Even":
                    return AddrTypeAddressNumberParityType.Even;
                case "Odd":
                    return AddrTypeAddressNumberParityType.Odd;
            }
            throw new Exception("Cannot unmarshal type AddrTypeAddressNumberParityType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAddressNumberParityType)untypedValue;
            switch (value)
            {
                case AddrTypeAddressNumberParityType.Even:
                    serializer.Serialize(writer, "Even");
                    return;
                case AddrTypeAddressNumberParityType.Odd:
                    serializer.Serialize(writer, "Odd");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAddressNumberParityType");
        }

        public static readonly AddrTypeAddressNumberParityTypeConverter Singleton = new AddrTypeAddressNumberParityTypeConverter();
    }

    internal class AddressNumberPrefixTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressNumberPrefixType) || t == typeof(AddressNumberPrefixType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.AddressNumberPrefix_type")
            {
                return AddressNumberPrefixType.AddrTypeAddressNumberPrefixType;
            }
            throw new Exception("Cannot unmarshal type AddressNumberPrefixType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressNumberPrefixType)untypedValue;
            if (value == AddressNumberPrefixType.AddrTypeAddressNumberPrefixType)
            {
                serializer.Serialize(writer, "addr_type.AddressNumberPrefix_type");
                return;
            }
            throw new Exception("Cannot marshal type AddressNumberPrefixType");
        }

        public static readonly AddressNumberPrefixTypeConverter Singleton = new AddressNumberPrefixTypeConverter();
    }

    internal class AddressNumberSuffixTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressNumberSuffixType) || t == typeof(AddressNumberSuffixType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.AddressNumberSuffix_type")
            {
                return AddressNumberSuffixType.AddrTypeAddressNumberSuffixType;
            }
            throw new Exception("Cannot unmarshal type AddressNumberSuffixType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressNumberSuffixType)untypedValue;
            if (value == AddressNumberSuffixType.AddrTypeAddressNumberSuffixType)
            {
                serializer.Serialize(writer, "addr_type.AddressNumberSuffix_type");
                return;
            }
            throw new Exception("Cannot marshal type AddressNumberSuffixType");
        }

        public static readonly AddressNumberSuffixTypeConverter Singleton = new AddressNumberSuffixTypeConverter();
    }

    internal class AddrTypeAttachedElementTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeAttachedElementType) || t == typeof(AddrTypeAttachedElementType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeAttachedElementType)untypedValue;
            switch (value)
            {
                case AddrTypeAttachedElementType.Attached:
                    serializer.Serialize(writer, "Attached");
                    return;
                case AddrTypeAttachedElementType.NotAttached:
                    serializer.Serialize(writer, "Not Attached");
                    return;
                case AddrTypeAttachedElementType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeAttachedElementType");
        }

        public static readonly AddrTypeAttachedElementTypeConverter Singleton = new AddrTypeAttachedElementTypeConverter();
    }

    internal class CompleteLandmarkNameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteLandmarkNameType) || t == typeof(CompleteLandmarkNameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.CompleteLandmarkName_type")
            {
                return CompleteLandmarkNameType.AddrTypeCompleteLandmarkNameType;
            }
            throw new Exception("Cannot unmarshal type CompleteLandmarkNameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CompleteLandmarkNameType)untypedValue;
            if (value == CompleteLandmarkNameType.AddrTypeCompleteLandmarkNameType)
            {
                serializer.Serialize(writer, "addr_type.CompleteLandmarkName_type");
                return;
            }
            throw new Exception("Cannot marshal type CompleteLandmarkNameType");
        }

        public static readonly CompleteLandmarkNameTypeConverter Singleton = new CompleteLandmarkNameTypeConverter();
    }

    internal class LandmarkNameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LandmarkNameType) || t == typeof(LandmarkNameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.LandmarkName_type")
            {
                return LandmarkNameType.AddrTypeLandmarkNameType;
            }
            throw new Exception("Cannot unmarshal type LandmarkNameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LandmarkNameType)untypedValue;
            if (value == LandmarkNameType.AddrTypeLandmarkNameType)
            {
                serializer.Serialize(writer, "addr_type.LandmarkName_type");
                return;
            }
            throw new Exception("Cannot marshal type LandmarkNameType");
        }

        public static readonly LandmarkNameTypeConverter Singleton = new LandmarkNameTypeConverter();
    }

    internal class CompletePlaceNameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CompletePlaceNameType) || t == typeof(CompletePlaceNameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.CompletePlaceName_type")
            {
                return CompletePlaceNameType.AddrTypeCompletePlaceNameType;
            }
            throw new Exception("Cannot unmarshal type CompletePlaceNameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CompletePlaceNameType)untypedValue;
            if (value == CompletePlaceNameType.AddrTypeCompletePlaceNameType)
            {
                serializer.Serialize(writer, "addr_type.CompletePlaceName_type");
                return;
            }
            throw new Exception("Cannot marshal type CompletePlaceNameType");
        }

        public static readonly CompletePlaceNameTypeConverter Singleton = new CompletePlaceNameTypeConverter();
    }

    internal class PlaceNameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlaceNameType) || t == typeof(PlaceNameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.PlaceName_type")
            {
                return PlaceNameType.AddrTypePlaceNameType;
            }
            throw new Exception("Cannot unmarshal type PlaceNameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlaceNameType)untypedValue;
            if (value == PlaceNameType.AddrTypePlaceNameType)
            {
                serializer.Serialize(writer, "addr_type.PlaceName_type");
                return;
            }
            throw new Exception("Cannot marshal type PlaceNameType");
        }

        public static readonly PlaceNameTypeConverter Singleton = new PlaceNameTypeConverter();
    }

    internal class AddrTypePlaceNameTypeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypePlaceNameTypeType) || t == typeof(AddrTypePlaceNameTypeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypePlaceNameTypeType)untypedValue;
            switch (value)
            {
                case AddrTypePlaceNameTypeType.County:
                    serializer.Serialize(writer, "County");
                    return;
                case AddrTypePlaceNameTypeType.MunicipalJurisdiction:
                    serializer.Serialize(writer, "MunicipalJurisdiction");
                    return;
                case AddrTypePlaceNameTypeType.UspsCommunity:
                    serializer.Serialize(writer, "USPSCommunity");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypePlaceNameTypeType");
        }

        public static readonly AddrTypePlaceNameTypeTypeConverter Singleton = new AddrTypePlaceNameTypeTypeConverter();
    }

    internal class CompleteStreetNameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteStreetNameType) || t == typeof(CompleteStreetNameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.CompleteStreetName_type")
            {
                return CompleteStreetNameType.AddrTypeCompleteStreetNameType;
            }
            throw new Exception("Cannot unmarshal type CompleteStreetNameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CompleteStreetNameType)untypedValue;
            if (value == CompleteStreetNameType.AddrTypeCompleteStreetNameType)
            {
                serializer.Serialize(writer, "addr_type.CompleteStreetName_type");
                return;
            }
            throw new Exception("Cannot marshal type CompleteStreetNameType");
        }

        public static readonly CompleteStreetNameTypeConverter Singleton = new CompleteStreetNameTypeConverter();
    }

    internal class StreetNamePostDirectionalTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostDirectionalType) || t == typeof(StreetNamePostDirectionalType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.StreetNamePreDirectional_type")
            {
                return StreetNamePostDirectionalType.AddrTypeStreetNamePreDirectionalType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostDirectionalType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreetNamePostDirectionalType)untypedValue;
            if (value == StreetNamePostDirectionalType.AddrTypeStreetNamePreDirectionalType)
            {
                serializer.Serialize(writer, "addr_type.StreetNamePreDirectional_type");
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostDirectionalType");
        }

        public static readonly StreetNamePostDirectionalTypeConverter Singleton = new StreetNamePostDirectionalTypeConverter();
    }

    internal class StreetNamePostModifierTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostModifierType) || t == typeof(StreetNamePostModifierType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.StreetNamePreModifier_type")
            {
                return StreetNamePostModifierType.AddrTypeStreetNamePreModifierType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostModifierType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreetNamePostModifierType)untypedValue;
            if (value == StreetNamePostModifierType.AddrTypeStreetNamePreModifierType)
            {
                serializer.Serialize(writer, "addr_type.StreetNamePreModifier_type");
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostModifierType");
        }

        public static readonly StreetNamePostModifierTypeConverter Singleton = new StreetNamePostModifierTypeConverter();
    }

    internal class StreetNamePostTypeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreetNamePostTypeType) || t == typeof(StreetNamePostTypeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.StreetNamePreType_type")
            {
                return StreetNamePostTypeType.AddrTypeStreetNamePreTypeType;
            }
            throw new Exception("Cannot unmarshal type StreetNamePostTypeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreetNamePostTypeType)untypedValue;
            if (value == StreetNamePostTypeType.AddrTypeStreetNamePreTypeType)
            {
                serializer.Serialize(writer, "addr_type.StreetNamePreType_type");
                return;
            }
            throw new Exception("Cannot marshal type StreetNamePostTypeType");
        }

        public static readonly StreetNamePostTypeTypeConverter Singleton = new StreetNamePostTypeTypeConverter();
    }

    internal class CompleteSubaddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CompleteSubaddressType) || t == typeof(CompleteSubaddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.CompleteSubaddress_type")
            {
                return CompleteSubaddressType.AddrTypeCompleteSubaddressType;
            }
            throw new Exception("Cannot unmarshal type CompleteSubaddressType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CompleteSubaddressType)untypedValue;
            if (value == CompleteSubaddressType.AddrTypeCompleteSubaddressType)
            {
                serializer.Serialize(writer, "addr_type.CompleteSubaddress_type");
                return;
            }
            throw new Exception("Cannot marshal type CompleteSubaddressType");
        }

        public static readonly CompleteSubaddressTypeConverter Singleton = new CompleteSubaddressTypeConverter();
    }

    internal class SubaddressElementTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SubaddressElementType) || t == typeof(SubaddressElementType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.SubaddressElement_type")
            {
                return SubaddressElementType.AddrTypeSubaddressElementType;
            }
            throw new Exception("Cannot unmarshal type SubaddressElementType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SubaddressElementType)untypedValue;
            if (value == SubaddressElementType.AddrTypeSubaddressElementType)
            {
                serializer.Serialize(writer, "addr_type.SubaddressElement_type");
                return;
            }
            throw new Exception("Cannot marshal type SubaddressElementType");
        }

        public static readonly SubaddressElementTypeConverter Singleton = new SubaddressElementTypeConverter();
    }

    internal class AddrTypeSubaddressComponentOrderTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeSubaddressComponentOrderType) || t == typeof(AddrTypeSubaddressComponentOrderType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeSubaddressComponentOrderType)untypedValue;
            switch (value)
            {
                case AddrTypeSubaddressComponentOrderType.The1:
                    serializer.Serialize(writer, "1");
                    return;
                case AddrTypeSubaddressComponentOrderType.The2:
                    serializer.Serialize(writer, "2");
                    return;
                case AddrTypeSubaddressComponentOrderType.The3:
                    serializer.Serialize(writer, "3");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeSubaddressComponentOrderType");
        }

        public static readonly AddrTypeSubaddressComponentOrderTypeConverter Singleton = new AddrTypeSubaddressComponentOrderTypeConverter();
    }

    internal class AddrTypeMailableAddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeMailableAddressType) || t == typeof(AddrTypeMailableAddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeMailableAddressType)untypedValue;
            switch (value)
            {
                case AddrTypeMailableAddressType.No:
                    serializer.Serialize(writer, "No");
                    return;
                case AddrTypeMailableAddressType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
                case AddrTypeMailableAddressType.Yes:
                    serializer.Serialize(writer, "Yes");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeMailableAddressType");
        }

        public static readonly AddrTypeMailableAddressTypeConverter Singleton = new AddrTypeMailableAddressTypeConverter();
    }

    internal class AddrTypeOfficialStatusTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeOfficialStatusType) || t == typeof(AddrTypeOfficialStatusType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeOfficialStatusType)untypedValue;
            switch (value)
            {
                case AddrTypeOfficialStatusType.AlternateNamesEstablishedByColloquialUseInACommunity:
                    serializer.Serialize(writer, "Alternate Names Established by Colloquial Use in a Community");
                    return;
                case AddrTypeOfficialStatusType.AlternateOrAlias:
                    serializer.Serialize(writer, "Alternate or Alias");
                    return;
                case AddrTypeOfficialStatusType.AlternatesEstablishedByAnAddressAuthority:
                    serializer.Serialize(writer, "Alternates Established by an Address Authority");
                    return;
                case AddrTypeOfficialStatusType.Official:
                    serializer.Serialize(writer, "Official");
                    return;
                case AddrTypeOfficialStatusType.OfficialAlternateOrAlias:
                    serializer.Serialize(writer, "Official Alternate or Alias");
                    return;
                case AddrTypeOfficialStatusType.OfficialRenamingActionOfTheAddressAuthority:
                    serializer.Serialize(writer, "Official Renaming Action of the Address Authority");
                    return;
                case AddrTypeOfficialStatusType.PostedOrVanityAddress:
                    serializer.Serialize(writer, "Posted or Vanity Address");
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateNamesFrequentlyEncountered:
                    serializer.Serialize(writer, "Unofficial Alternate Names Frequently Encountered");
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateNamesInUseByAnAgencyOrEntity:
                    serializer.Serialize(writer, "Unofficial Alternate Names In Use by an Agency or Entity");
                    return;
                case AddrTypeOfficialStatusType.UnofficialAlternateOrAlias:
                    serializer.Serialize(writer, "Unofficial Alternate or Alias");
                    return;
                case AddrTypeOfficialStatusType.VerifiedInvalid:
                    serializer.Serialize(writer, "Verified Invalid");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeOfficialStatusType");
        }

        public static readonly AddrTypeOfficialStatusTypeConverter Singleton = new AddrTypeOfficialStatusTypeConverter();
    }

    internal class UspsAddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UspsAddressType) || t == typeof(UspsAddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.USPSAddress_type")
            {
                return UspsAddressType.AddrTypeUspsAddressType;
            }
            throw new Exception("Cannot unmarshal type UspsAddressType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UspsAddressType)untypedValue;
            if (value == UspsAddressType.AddrTypeUspsAddressType)
            {
                serializer.Serialize(writer, "addr_type.USPSAddress_type");
                return;
            }
            throw new Exception("Cannot marshal type UspsAddressType");
        }

        public static readonly UspsAddressTypeConverter Singleton = new UspsAddressTypeConverter();
    }

    internal class UspsBoxTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UspsBoxType) || t == typeof(UspsBoxType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.USPSBox_type")
            {
                return UspsBoxType.AddrTypeUspsBoxType;
            }
            throw new Exception("Cannot unmarshal type UspsBoxType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UspsBoxType)untypedValue;
            if (value == UspsBoxType.AddrTypeUspsBoxType)
            {
                serializer.Serialize(writer, "addr_type.USPSBox_type");
                return;
            }
            throw new Exception("Cannot marshal type UspsBoxType");
        }

        public static readonly UspsBoxTypeConverter Singleton = new UspsBoxTypeConverter();
    }

    internal class UspsRouteTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UspsRouteType) || t == typeof(UspsRouteType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "addr_type.USPSRoute_type")
            {
                return UspsRouteType.AddrTypeUspsRouteType;
            }
            throw new Exception("Cannot unmarshal type UspsRouteType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UspsRouteType)untypedValue;
            if (value == UspsRouteType.AddrTypeUspsRouteType)
            {
                serializer.Serialize(writer, "addr_type.USPSRoute_type");
                return;
            }
            throw new Exception("Cannot marshal type UspsRouteType");
        }

        public static readonly UspsRouteTypeConverter Singleton = new UspsRouteTypeConverter();
    }

    internal class AddrTypeActionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddrTypeActionType) || t == typeof(AddrTypeActionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ADD":
                    return AddrTypeActionType.Add;
                case "DELETE":
                    return AddrTypeActionType.Delete;
            }
            throw new Exception("Cannot unmarshal type AddrTypeActionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddrTypeActionType)untypedValue;
            switch (value)
            {
                case AddrTypeActionType.Add:
                    serializer.Serialize(writer, "ADD");
                    return;
                case AddrTypeActionType.Delete:
                    serializer.Serialize(writer, "DELETE");
                    return;
            }
            throw new Exception("Cannot marshal type AddrTypeActionType");
        }

        public static readonly AddrTypeActionTypeConverter Singleton = new AddrTypeActionTypeConverter();
    }

    internal class PollingPlaceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PollingPlaceType) || t == typeof(PollingPlaceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.ReportingUnit")
            {
                return PollingPlaceType.VriReportingUnit;
            }
            throw new Exception("Cannot unmarshal type PollingPlaceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PollingPlaceType)untypedValue;
            if (value == PollingPlaceType.VriReportingUnit)
            {
                serializer.Serialize(writer, "VRI.ReportingUnit");
                return;
            }
            throw new Exception("Cannot marshal type PollingPlaceType");
        }

        public static readonly PollingPlaceTypeConverter Singleton = new PollingPlaceTypeConverter();
    }

    internal class LocationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LocationType) || t == typeof(LocationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Location")
            {
                return LocationType.VriLocation;
            }
            throw new Exception("Cannot unmarshal type LocationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LocationType)untypedValue;
            if (value == LocationType.VriLocation)
            {
                serializer.Serialize(writer, "VRI.Location");
                return;
            }
            throw new Exception("Cannot marshal type LocationType");
        }

        public static readonly LocationTypeConverter Singleton = new LocationTypeConverter();
    }

    internal class LatLngTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LatLngType) || t == typeof(LatLngType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.LatLng")
            {
                return LatLngType.VriLatLng;
            }
            throw new Exception("Cannot unmarshal type LatLngType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LatLngType)untypedValue;
            if (value == LatLngType.VriLatLng)
            {
                serializer.Serialize(writer, "VRI.LatLng");
                return;
            }
            throw new Exception("Cannot marshal type LatLngType");
        }

        public static readonly LatLngTypeConverter Singleton = new LatLngTypeConverter();
    }

    internal class VriReportingUnitTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriReportingUnitType) || t == typeof(VriReportingUnitType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriReportingUnitType)untypedValue;
            switch (value)
            {
                case VriReportingUnitType.BallotBatch:
                    serializer.Serialize(writer, "ballot-batch");
                    return;
                case VriReportingUnitType.BallotStyleArea:
                    serializer.Serialize(writer, "ballot-style-area");
                    return;
                case VriReportingUnitType.Borough:
                    serializer.Serialize(writer, "borough");
                    return;
                case VriReportingUnitType.City:
                    serializer.Serialize(writer, "city");
                    return;
                case VriReportingUnitType.CityCouncil:
                    serializer.Serialize(writer, "city-council");
                    return;
                case VriReportingUnitType.CombinedPrecinct:
                    serializer.Serialize(writer, "combined-precinct");
                    return;
                case VriReportingUnitType.Congressional:
                    serializer.Serialize(writer, "congressional");
                    return;
                case VriReportingUnitType.County:
                    serializer.Serialize(writer, "county");
                    return;
                case VriReportingUnitType.CountyCouncil:
                    serializer.Serialize(writer, "county-council");
                    return;
                case VriReportingUnitType.DropBox:
                    serializer.Serialize(writer, "drop-box");
                    return;
                case VriReportingUnitType.Judicial:
                    serializer.Serialize(writer, "judicial");
                    return;
                case VriReportingUnitType.Municipality:
                    serializer.Serialize(writer, "municipality");
                    return;
                case VriReportingUnitType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriReportingUnitType.PollingPlace:
                    serializer.Serialize(writer, "polling-place");
                    return;
                case VriReportingUnitType.Precinct:
                    serializer.Serialize(writer, "precinct");
                    return;
                case VriReportingUnitType.School:
                    serializer.Serialize(writer, "school");
                    return;
                case VriReportingUnitType.Special:
                    serializer.Serialize(writer, "special");
                    return;
                case VriReportingUnitType.SplitPrecinct:
                    serializer.Serialize(writer, "split-precinct");
                    return;
                case VriReportingUnitType.State:
                    serializer.Serialize(writer, "state");
                    return;
                case VriReportingUnitType.StateHouse:
                    serializer.Serialize(writer, "state-house");
                    return;
                case VriReportingUnitType.StateSenate:
                    serializer.Serialize(writer, "state-senate");
                    return;
                case VriReportingUnitType.Town:
                    serializer.Serialize(writer, "town");
                    return;
                case VriReportingUnitType.Township:
                    serializer.Serialize(writer, "township");
                    return;
                case VriReportingUnitType.Utility:
                    serializer.Serialize(writer, "utility");
                    return;
                case VriReportingUnitType.Village:
                    serializer.Serialize(writer, "village");
                    return;
                case VriReportingUnitType.VoteCenter:
                    serializer.Serialize(writer, "vote-center");
                    return;
                case VriReportingUnitType.Ward:
                    serializer.Serialize(writer, "ward");
                    return;
                case VriReportingUnitType.Water:
                    serializer.Serialize(writer, "water");
                    return;
            }
            throw new Exception("Cannot marshal type VriReportingUnitType");
        }

        public static readonly VriReportingUnitTypeConverter Singleton = new VriReportingUnitTypeConverter();
    }

    internal class ElectionAdministrationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ElectionAdministrationType) || t == typeof(ElectionAdministrationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.ElectionAdministration")
            {
                return ElectionAdministrationType.VriElectionAdministration;
            }
            throw new Exception("Cannot unmarshal type ElectionAdministrationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ElectionAdministrationType)untypedValue;
            if (value == ElectionAdministrationType.VriElectionAdministration)
            {
                serializer.Serialize(writer, "VRI.ElectionAdministration");
                return;
            }
            throw new Exception("Cannot marshal type ElectionAdministrationType");
        }

        public static readonly ElectionAdministrationTypeConverter Singleton = new ElectionAdministrationTypeConverter();
    }

    internal class ContactMethodTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContactMethodType) || t == typeof(ContactMethodType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "VRI.ContactMethod":
                    return ContactMethodType.VriContactMethod;
                case "VRI.PhoneContactMethod":
                    return ContactMethodType.VriPhoneContactMethod;
            }
            throw new Exception("Cannot unmarshal type ContactMethodType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContactMethodType)untypedValue;
            switch (value)
            {
                case ContactMethodType.VriContactMethod:
                    serializer.Serialize(writer, "VRI.ContactMethod");
                    return;
                case ContactMethodType.VriPhoneContactMethod:
                    serializer.Serialize(writer, "VRI.PhoneContactMethod");
                    return;
            }
            throw new Exception("Cannot marshal type ContactMethodType");
        }

        public static readonly ContactMethodTypeConverter Singleton = new ContactMethodTypeConverter();
    }

    internal class VriPhoneCapabilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriPhoneCapability) || t == typeof(VriPhoneCapability?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriPhoneCapability)untypedValue;
            switch (value)
            {
                case VriPhoneCapability.Fax:
                    serializer.Serialize(writer, "fax");
                    return;
                case VriPhoneCapability.Mms:
                    serializer.Serialize(writer, "mms");
                    return;
                case VriPhoneCapability.Sms:
                    serializer.Serialize(writer, "sms");
                    return;
                case VriPhoneCapability.Voice:
                    serializer.Serialize(writer, "voice");
                    return;
            }
            throw new Exception("Cannot marshal type VriPhoneCapability");
        }

        public static readonly VriPhoneCapabilityConverter Singleton = new VriPhoneCapabilityConverter();
    }

    internal class VriContactMethodTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriContactMethodType) || t == typeof(VriContactMethodType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriContactMethodType)untypedValue;
            switch (value)
            {
                case VriContactMethodType.Email:
                    serializer.Serialize(writer, "email");
                    return;
                case VriContactMethodType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriContactMethodType.Phone:
                    serializer.Serialize(writer, "phone");
                    return;
            }
            throw new Exception("Cannot marshal type VriContactMethodType");
        }

        public static readonly VriContactMethodTypeConverter Singleton = new VriContactMethodTypeConverter();
    }

    internal class ErrorTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ErrorType) || t == typeof(ErrorType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Error")
            {
                return ErrorType.VriError;
            }
            throw new Exception("Cannot unmarshal type ErrorType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ErrorType)untypedValue;
            if (value == ErrorType.VriError)
            {
                serializer.Serialize(writer, "VRI.Error");
                return;
            }
            throw new Exception("Cannot marshal type ErrorType");
        }

        public static readonly ErrorTypeConverter Singleton = new ErrorTypeConverter();
    }

    internal class VriRequestErrorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestError) || t == typeof(VriRequestError?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriRequestError)untypedValue;
            switch (value)
            {
                case VriRequestError.IdentityLookupFailed:
                    serializer.Serialize(writer, "identity-lookup-failed");
                    return;
                case VriRequestError.Incomplete:
                    serializer.Serialize(writer, "incomplete");
                    return;
                case VriRequestError.Ineligible:
                    serializer.Serialize(writer, "ineligible");
                    return;
                case VriRequestError.InvalidForm:
                    serializer.Serialize(writer, "invalid-form");
                    return;
                case VriRequestError.Other:
                    serializer.Serialize(writer, "other");
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestError");
        }

        public static readonly VriRequestErrorConverter Singleton = new VriRequestErrorConverter();
    }

    internal class VriRequestFormConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestForm) || t == typeof(VriRequestForm?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriRequestForm)untypedValue;
            switch (value)
            {
                case VriRequestForm.Fpca:
                    serializer.Serialize(writer, "fpca");
                    return;
                case VriRequestForm.Nvra:
                    serializer.Serialize(writer, "nvra");
                    return;
                case VriRequestForm.Other:
                    serializer.Serialize(writer, "other");
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestForm");
        }

        public static readonly VriRequestFormConverter Singleton = new VriRequestFormConverter();
    }

    internal class RequestHelperTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RequestHelperType) || t == typeof(RequestHelperType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.RequestHelper")
            {
                return RequestHelperType.VriRequestHelper;
            }
            throw new Exception("Cannot unmarshal type RequestHelperType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RequestHelperType)untypedValue;
            if (value == RequestHelperType.VriRequestHelper)
            {
                serializer.Serialize(writer, "VRI.RequestHelper");
                return;
            }
            throw new Exception("Cannot marshal type RequestHelperType");
        }

        public static readonly RequestHelperTypeConverter Singleton = new RequestHelperTypeConverter();
    }

    internal class NameTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameType) || t == typeof(NameType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Name")
            {
                return NameType.VriName;
            }
            throw new Exception("Cannot unmarshal type NameType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NameType)untypedValue;
            if (value == NameType.VriName)
            {
                serializer.Serialize(writer, "VRI.Name");
                return;
            }
            throw new Exception("Cannot marshal type NameType");
        }

        public static readonly NameTypeConverter Singleton = new NameTypeConverter();
    }

    internal class PhoneTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PhoneType) || t == typeof(PhoneType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.PhoneContactMethod")
            {
                return PhoneType.VriPhoneContactMethod;
            }
            throw new Exception("Cannot unmarshal type PhoneType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PhoneType)untypedValue;
            if (value == PhoneType.VriPhoneContactMethod)
            {
                serializer.Serialize(writer, "VRI.PhoneContactMethod");
                return;
            }
            throw new Exception("Cannot marshal type PhoneType");
        }

        public static readonly PhoneTypeConverter Singleton = new PhoneTypeConverter();
    }

    internal class PreviousSignatureTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PreviousSignatureType) || t == typeof(PreviousSignatureType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Signature")
            {
                return PreviousSignatureType.VriSignature;
            }
            throw new Exception("Cannot unmarshal type PreviousSignatureType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PreviousSignatureType)untypedValue;
            if (value == PreviousSignatureType.VriSignature)
            {
                serializer.Serialize(writer, "VRI.Signature");
                return;
            }
            throw new Exception("Cannot marshal type PreviousSignatureType");
        }

        public static readonly PreviousSignatureTypeConverter Singleton = new PreviousSignatureTypeConverter();
    }

    internal class FluffyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyType) || t == typeof(FluffyType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Image")
            {
                return FluffyType.VriImage;
            }
            throw new Exception("Cannot unmarshal type FluffyType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FluffyType)untypedValue;
            if (value == FluffyType.VriImage)
            {
                serializer.Serialize(writer, "VRI.Image");
                return;
            }
            throw new Exception("Cannot marshal type FluffyType");
        }

        public static readonly FluffyTypeConverter Singleton = new FluffyTypeConverter();
    }

    internal class VriSignatureSourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriSignatureSource) || t == typeof(VriSignatureSource?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriSignatureSource)untypedValue;
            switch (value)
            {
                case VriSignatureSource.Dmv:
                    serializer.Serialize(writer, "dmv");
                    return;
                case VriSignatureSource.Local:
                    serializer.Serialize(writer, "local");
                    return;
                case VriSignatureSource.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriSignatureSource.State:
                    serializer.Serialize(writer, "state");
                    return;
                case VriSignatureSource.Voter:
                    serializer.Serialize(writer, "voter");
                    return;
            }
            throw new Exception("Cannot marshal type VriSignatureSource");
        }

        public static readonly VriSignatureSourceConverter Singleton = new VriSignatureSourceConverter();
    }

    internal class VriSignatureTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriSignatureType) || t == typeof(VriSignatureType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriSignatureType)untypedValue;
            switch (value)
            {
                case VriSignatureType.Dynamic:
                    serializer.Serialize(writer, "dynamic");
                    return;
                case VriSignatureType.Electronic:
                    serializer.Serialize(writer, "electronic");
                    return;
                case VriSignatureType.Other:
                    serializer.Serialize(writer, "other");
                    return;
            }
            throw new Exception("Cannot marshal type VriSignatureType");
        }

        public static readonly VriSignatureTypeConverter Singleton = new VriSignatureTypeConverter();
    }

    internal class VriVoterHelperTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterHelperType) || t == typeof(VriVoterHelperType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "assistant":
                    return VriVoterHelperType.Assistant;
                case "witness":
                    return VriVoterHelperType.Witness;
            }
            throw new Exception("Cannot unmarshal type VriVoterHelperType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriVoterHelperType)untypedValue;
            switch (value)
            {
                case VriVoterHelperType.Assistant:
                    serializer.Serialize(writer, "assistant");
                    return;
                case VriVoterHelperType.Witness:
                    serializer.Serialize(writer, "witness");
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterHelperType");
        }

        public static readonly VriVoterHelperTypeConverter Singleton = new VriVoterHelperTypeConverter();
    }

    internal class VriRequestMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestMethod) || t == typeof(VriRequestMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriRequestMethod)untypedValue;
            switch (value)
            {
                case VriRequestMethod.ArmedForcesRecruitmentOffice:
                    serializer.Serialize(writer, "armed-forces-recruitment-office");
                    return;
                case VriRequestMethod.MotorVehicleOffice:
                    serializer.Serialize(writer, "motor-vehicle-office");
                    return;
                case VriRequestMethod.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriRequestMethod.OtherAgencyDesignatedByState:
                    serializer.Serialize(writer, "other-agency-designated-by-state");
                    return;
                case VriRequestMethod.PublicAssistanceOffice:
                    serializer.Serialize(writer, "public-assistance-office");
                    return;
                case VriRequestMethod.RegistrationDriveFromAdvocacyGroupOrPoliticalParty:
                    serializer.Serialize(writer, "registration-drive-from-advocacy-group-or-political-party");
                    return;
                case VriRequestMethod.StateFundedAgencyServingPersonsWithDisabilities:
                    serializer.Serialize(writer, "state-funded-agency-serving-persons-with-disabilities");
                    return;
                case VriRequestMethod.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
                case VriRequestMethod.VoterViaElectionRegistrarsOffice:
                    serializer.Serialize(writer, "voter-via-election-registrars-office");
                    return;
                case VriRequestMethod.VoterViaEmail:
                    serializer.Serialize(writer, "voter-via-email");
                    return;
                case VriRequestMethod.VoterViaFax:
                    serializer.Serialize(writer, "voter-via-fax");
                    return;
                case VriRequestMethod.VoterViaInternet:
                    serializer.Serialize(writer, "voter-via-internet");
                    return;
                case VriRequestMethod.VoterViaMail:
                    serializer.Serialize(writer, "voter-via-mail");
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestMethod");
        }

        public static readonly VriRequestMethodConverter Singleton = new VriRequestMethodConverter();
    }

    internal class RequestProxyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RequestProxyType) || t == typeof(RequestProxyType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.RequestProxy")
            {
                return RequestProxyType.VriRequestProxy;
            }
            throw new Exception("Cannot unmarshal type RequestProxyType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RequestProxyType)untypedValue;
            if (value == RequestProxyType.VriRequestProxy)
            {
                serializer.Serialize(writer, "VRI.RequestProxy");
                return;
            }
            throw new Exception("Cannot marshal type RequestProxyType");
        }

        public static readonly RequestProxyTypeConverter Singleton = new RequestProxyTypeConverter();
    }

    internal class VriRequestProxyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriRequestProxyType) || t == typeof(VriRequestProxyType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriRequestProxyType)untypedValue;
            switch (value)
            {
                case VriRequestProxyType.ArmedForcesRecruitmentOffice:
                    serializer.Serialize(writer, "armed-forces-recruitment-office");
                    return;
                case VriRequestProxyType.MotorVehicleOffice:
                    serializer.Serialize(writer, "motor-vehicle-office");
                    return;
                case VriRequestProxyType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriRequestProxyType.OtherAgencyDesignatedByState:
                    serializer.Serialize(writer, "other-agency-designated-by-state");
                    return;
                case VriRequestProxyType.PublicAssistanceOffice:
                    serializer.Serialize(writer, "public-assistance-office");
                    return;
                case VriRequestProxyType.RegistrationDriveFromAdvocacyGroupOrPoliticalParty:
                    serializer.Serialize(writer, "registration-drive-from-advocacy-group-or-political-party");
                    return;
                case VriRequestProxyType.StateFundedAgencyServingPersonsWithDisabilities:
                    serializer.Serialize(writer, "state-funded-agency-serving-persons-with-disabilities");
                    return;
            }
            throw new Exception("Cannot marshal type VriRequestProxyType");
        }

        public static readonly VriRequestProxyTypeConverter Singleton = new VriRequestProxyTypeConverter();
    }

    internal class SubjectTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SubjectType) || t == typeof(SubjectType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Voter")
            {
                return SubjectType.VriVoter;
            }
            throw new Exception("Cannot unmarshal type SubjectType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SubjectType)untypedValue;
            if (value == SubjectType.VriVoter)
            {
                serializer.Serialize(writer, "VRI.Voter");
                return;
            }
            throw new Exception("Cannot marshal type SubjectType");
        }

        public static readonly SubjectTypeConverter Singleton = new SubjectTypeConverter();
    }

    internal class PartyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PartyType) || t == typeof(PartyType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.Party")
            {
                return PartyType.VriParty;
            }
            throw new Exception("Cannot unmarshal type PartyType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PartyType)untypedValue;
            if (value == PartyType.VriParty)
            {
                serializer.Serialize(writer, "VRI.Party");
                return;
            }
            throw new Exception("Cannot marshal type PartyType");
        }

        public static readonly PartyTypeConverter Singleton = new PartyTypeConverter();
    }

    internal class VoterClassificationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VoterClassificationType) || t == typeof(VoterClassificationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.VoterClassification")
            {
                return VoterClassificationType.VriVoterClassification;
            }
            throw new Exception("Cannot unmarshal type VoterClassificationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VoterClassificationType)untypedValue;
            if (value == VoterClassificationType.VriVoterClassification)
            {
                serializer.Serialize(writer, "VRI.VoterClassification");
                return;
            }
            throw new Exception("Cannot marshal type VoterClassificationType");
        }

        public static readonly VoterClassificationTypeConverter Singleton = new VoterClassificationTypeConverter();
    }

    internal class VriAssertionValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriAssertionValue) || t == typeof(VriAssertionValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriAssertionValue)untypedValue;
            switch (value)
            {
                case VriAssertionValue.No:
                    serializer.Serialize(writer, "no");
                    return;
                case VriAssertionValue.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriAssertionValue.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
                case VriAssertionValue.Yes:
                    serializer.Serialize(writer, "yes");
                    return;
            }
            throw new Exception("Cannot marshal type VriAssertionValue");
        }

        public static readonly VriAssertionValueConverter Singleton = new VriAssertionValueConverter();
    }

    internal class VriVoterClassificationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterClassificationType) || t == typeof(VriVoterClassificationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriVoterClassificationType)untypedValue;
            switch (value)
            {
                case VriVoterClassificationType.ActivatedNationalGuard:
                    serializer.Serialize(writer, "activated-national-guard");
                    return;
                case VriVoterClassificationType.ActiveDuty:
                    serializer.Serialize(writer, "active-duty");
                    return;
                case VriVoterClassificationType.ActiveDutySpouseOrDependent:
                    serializer.Serialize(writer, "active-duty-spouse-or-dependent");
                    return;
                case VriVoterClassificationType.CitizenAbroadIntentToReturn:
                    serializer.Serialize(writer, "citizen-abroad-intent-to-return");
                    return;
                case VriVoterClassificationType.CitizenAbroadNeverResided:
                    serializer.Serialize(writer, "citizen-abroad-never-resided");
                    return;
                case VriVoterClassificationType.CitizenAbroadReturnUncertain:
                    serializer.Serialize(writer, "citizen-abroad-return-uncertain");
                    return;
                case VriVoterClassificationType.Deceased:
                    serializer.Serialize(writer, "deceased");
                    return;
                case VriVoterClassificationType.DeclaredIncompetent:
                    serializer.Serialize(writer, "declared-incompetent");
                    return;
                case VriVoterClassificationType.EighteenOnElectionDay:
                    serializer.Serialize(writer, "eighteen-on-election-day");
                    return;
                case VriVoterClassificationType.Felon:
                    serializer.Serialize(writer, "felon");
                    return;
                case VriVoterClassificationType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriVoterClassificationType.PermanentlyDenied:
                    serializer.Serialize(writer, "permanently-denied");
                    return;
                case VriVoterClassificationType.ProtectedVoter:
                    serializer.Serialize(writer, "protected-voter");
                    return;
                case VriVoterClassificationType.RestoredFelon:
                    serializer.Serialize(writer, "restored-felon");
                    return;
                case VriVoterClassificationType.UnitedStatesCitizen:
                    serializer.Serialize(writer, "united-states-citizen");
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterClassificationType");
        }

        public static readonly VriVoterClassificationTypeConverter Singleton = new VriVoterClassificationTypeConverter();
    }

    internal class VoterIdTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VoterIdType) || t == typeof(VoterIdType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.VoterId")
            {
                return VoterIdType.VriVoterId;
            }
            throw new Exception("Cannot unmarshal type VoterIdType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VoterIdType)untypedValue;
            if (value == VoterIdType.VriVoterId)
            {
                serializer.Serialize(writer, "VRI.VoterId");
                return;
            }
            throw new Exception("Cannot marshal type VoterIdType");
        }

        public static readonly VoterIdTypeConverter Singleton = new VoterIdTypeConverter();
    }

    internal class VriVoterIdTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterIdType) || t == typeof(VriVoterIdType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriVoterIdType)untypedValue;
            switch (value)
            {
                case VriVoterIdType.DriversLicense:
                    serializer.Serialize(writer, "drivers-license");
                    return;
                case VriVoterIdType.LocalVoterRegistrationId:
                    serializer.Serialize(writer, "local-voter-registration-id");
                    return;
                case VriVoterIdType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriVoterIdType.Ssn:
                    serializer.Serialize(writer, "ssn");
                    return;
                case VriVoterIdType.Ssn4:
                    serializer.Serialize(writer, "ssn4");
                    return;
                case VriVoterIdType.StateId:
                    serializer.Serialize(writer, "state-id");
                    return;
                case VriVoterIdType.StateVoterRegistrationId:
                    serializer.Serialize(writer, "state-voter-registration-id");
                    return;
                case VriVoterIdType.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
                case VriVoterIdType.UnspecifiedDocument:
                    serializer.Serialize(writer, "unspecified-document");
                    return;
                case VriVoterIdType.UnspecifiedDocumentWithNameAndAddress:
                    serializer.Serialize(writer, "unspecified-document-with-name-and-address");
                    return;
                case VriVoterIdType.UnspecifiedDocumentWithPhotoIdentification:
                    serializer.Serialize(writer, "unspecified-document-with-photo-identification");
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterIdType");
        }

        public static readonly VriVoterIdTypeConverter Singleton = new VriVoterIdTypeConverter();
    }

    internal class VriVoterRequestTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterRequestType) || t == typeof(VriVoterRequestType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriVoterRequestType)untypedValue;
            switch (value)
            {
                case VriVoterRequestType.BallotRequest:
                    serializer.Serialize(writer, "ballot-request");
                    return;
                case VriVoterRequestType.Lookup:
                    serializer.Serialize(writer, "lookup");
                    return;
                case VriVoterRequestType.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case VriVoterRequestType.Registration:
                    serializer.Serialize(writer, "registration");
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterRequestType");
        }

        public static readonly VriVoterRequestTypeConverter Singleton = new VriVoterRequestTypeConverter();
    }

    internal class VoterRecordTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VoterRecordType) || t == typeof(VoterRecordType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.VoterRecord")
            {
                return VoterRecordType.VriVoterRecord;
            }
            throw new Exception("Cannot unmarshal type VoterRecordType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VoterRecordType)untypedValue;
            if (value == VoterRecordType.VriVoterRecord)
            {
                serializer.Serialize(writer, "VRI.VoterRecord");
                return;
            }
            throw new Exception("Cannot marshal type VoterRecordType");
        }

        public static readonly VoterRecordTypeConverter Singleton = new VoterRecordTypeConverter();
    }

    internal class VoterParticipationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VoterParticipationType) || t == typeof(VoterParticipationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.VoterParticipation")
            {
                return VoterParticipationType.VriVoterParticipation;
            }
            throw new Exception("Cannot unmarshal type VoterParticipationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VoterParticipationType)untypedValue;
            if (value == VoterParticipationType.VriVoterParticipation)
            {
                serializer.Serialize(writer, "VRI.VoterParticipation");
                return;
            }
            throw new Exception("Cannot marshal type VoterParticipationType");
        }

        public static readonly VoterParticipationTypeConverter Singleton = new VoterParticipationTypeConverter();
    }

    internal class BallotStyleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BallotStyleType) || t == typeof(BallotStyleType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VRI.BallotStyle")
            {
                return BallotStyleType.VriBallotStyle;
            }
            throw new Exception("Cannot unmarshal type BallotStyleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BallotStyleType)untypedValue;
            if (value == BallotStyleType.VriBallotStyle)
            {
                serializer.Serialize(writer, "VRI.BallotStyle");
                return;
            }
            throw new Exception("Cannot marshal type BallotStyleType");
        }

        public static readonly BallotStyleTypeConverter Singleton = new BallotStyleTypeConverter();
    }

    internal class VriVoterStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VriVoterStatus) || t == typeof(VriVoterStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
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

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VriVoterStatus)untypedValue;
            switch (value)
            {
                case VriVoterStatus.Active:
                    serializer.Serialize(writer, "active");
                    return;
                case VriVoterStatus.Inactive:
                    serializer.Serialize(writer, "inactive");
                    return;
                case VriVoterStatus.Other:
                    serializer.Serialize(writer, "other");
                    return;
            }
            throw new Exception("Cannot marshal type VriVoterStatus");
        }

        public static readonly VriVoterStatusConverter Singleton = new VriVoterStatusConverter();
    }
}
