using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace WebAppDockerDeployToAzure.Models
{
    public class NISTVoterReg
    {
        [JsonProperty("@type")]
        public CoordinateType Type { get; set; }

        [JsonProperty("AdditionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public VriAdditionalInfo[] AdditionalInfo { get; set; }

        [JsonProperty("GeneratedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GeneratedDate { get; set; }

        [JsonProperty("Issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        [JsonProperty("Subject", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoter Subject { get; set; }

        [JsonProperty("TransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public VriVoterRequestType[] CoordinateType { get; set; }

        [JsonProperty("VendorApplicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorApplicationId { get; set; }
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

    public partial class VriAddress
    {
        [JsonProperty("@type")]
        public VriAddressType Type { get; set; }

        [JsonProperty("CompleteAddressNumber", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber { get; set; }

        [JsonProperty("CompleteStreetName", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompleteStreetNameType CompleteStreetName { get; set; }

        [JsonProperty("CompletePlaceName", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeCompletePlaceNameType CompletePlaceName { get; set; }

        [JsonProperty("StateName", NullValueHandling = NullValueHandling.Ignore)]
        public string StateName { get; set; }

        [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        [JsonProperty("ZipPlus4", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipPlus4 { get; set; }

    }

 
    public partial class AddrTypeCompleteAddressNumberType
    {
        [JsonProperty("@type")]
        public CompleteAddressNumberType Type { get; set; }

        [JsonProperty("AddressNumber")]
        public string AddressNumber { get; set; }

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


        [JsonProperty("StreetNamePostType", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreTypeType StreetNamePostType { get; set; }

        [JsonProperty("StreetNamePreDirectional", NullValueHandling = NullValueHandling.Ignore)]
        public AddrTypeStreetNamePreDirectionalType StreetNamePreDirectional { get; set; }

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



    public partial class AddrTypeStreetNamePreTypeType
    {
        [JsonProperty("@type")]
        public StreetNamePostTypeType Type { get; set; }

        [JsonProperty("Separator", NullValueHandling = NullValueHandling.Ignore)]
        public string Separator { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }


    public enum CoordinateType { VriRequestAcknowledgement, VriRequestRejection, VriRequestSuccess, VriVoterRecordResults, VriVoterRecordsRequest };
    public enum AdditionalInfoType { VriAdditionalInfo };

    public enum PurpleType { VriFile, VriImage };

    public enum SubjectType { VriVoter };

    public enum ContactMethodType { VriContactMethod, VriPhoneContactMethod };
    public enum VriContactMethodType { Email, Other, Phone };

    public enum VriPhoneCapability { Fax, Mms, Sms, Voice };

    public enum PartyType { VriParty };

    public enum ExternalIdentifierType { VriExternalIdentifier };

    public enum VriIdentifierType { Fips, LocalLevel, NationalLevel, OcdId, Other, StateLevel };

    public enum VriSignatureSource { Dmv, Local, Other, State, Voter };

    public enum PreviousSignatureType { VriSignature };

    public enum VriSignatureType { Dynamic, Electronic, Other };

    public enum FluffyType { VriImage };

    public enum VriAssertionValue { No, Other, Unknown, Yes };

    public enum VoterClassificationType { VriVoterClassification };

    public enum VriVoterClassificationType { ActivatedNationalGuard, ActiveDuty, ActiveDutySpouseOrDependent, CitizenAbroadIntentToReturn, CitizenAbroadNeverResided, CitizenAbroadReturnUncertain, Deceased, DeclaredIncompetent, EighteenOnElectionDay, Felon, Other, PermanentlyDenied, ProtectedVoter, RestoredFelon, UnitedStatesCitizen };

    public enum VoterIdType { VriVoterId };

    public enum VriVoterIdType { DriversLicense, LocalVoterRegistrationId, Other, Ssn, Ssn4, StateId, StateVoterRegistrationId, Unknown, UnspecifiedDocument, UnspecifiedDocumentWithNameAndAddress, UnspecifiedDocumentWithPhotoIdentification };

    public enum VriAddressType { AddrCommunityAddressType, AddrFourNumberAddressRangeType, AddrGeneralAddressClassType, AddrIntersectionAddressType, AddrLandmarkAddressType, AddrNumberedThoroughfareAddressType, AddrTwoNumberAddressRangeType, AddrUnnumberedThoroughfareAddressType, AddrUspsGeneralDeliveryOfficeType, AddrUspsPostalDeliveryBoxType, AddrUspsPostalDeliveryRouteType };

    public enum CompleteAddressNumberType { AddrTypeCompleteAddressNumberType };

    public enum AddrTypeAddressNumberParityType { Even, Odd };

    public enum AddrTypeAttachedElementType { Attached, NotAttached, Unknown };

    public enum AddressNumberPrefixType { AddrTypeAddressNumberPrefixType };

    public enum AddressNumberSuffixType { AddrTypeAddressNumberSuffixType };

    public enum CompletePlaceNameType { AddrTypeCompletePlaceNameType };

    public enum PlaceNameType { AddrTypePlaceNameType };

    public enum AddrTypePlaceNameTypeType { County, MunicipalJurisdiction, UspsCommunity };

    public enum CompleteStreetNameType { AddrTypeCompleteStreetNameType };

    public enum StreetNamePostDirectionalType { AddrTypeStreetNamePreDirectionalType };

    public enum StreetNamePostModifierType { AddrTypeStreetNamePreModifierType };

    public enum StreetNamePostTypeType { AddrTypeStreetNamePreTypeType };

    public enum VriVoterRequestType { BallotRequest, Lookup, Other, Registration };

    public enum NameType { VriName };
}
