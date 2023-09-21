using System;
using System.Collections.Generic;

using System.Globalization;
//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Newtonsoft.Json.Converters;
namespace WebAppDockerDeployToAzure.Models
{
    public class NISTVoterReg
    {
        [JsonPropertyName("@type")]
        public CoordinateType Type { get; set; }

        [JsonPropertyName("AdditionalInfo")]
        public List<VriAdditionalInfo> AdditionalInfo { get; set; }

        [JsonPropertyName("GeneratedDate")]
        public DateTimeOffset? GeneratedDate { get; set; }

        [JsonPropertyName("Issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("Subject")]
        public VriVoter Subject { get; set; }

        [JsonPropertyName("TransactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("Type")]
        public List<VriVoterRequestType> CoordinateType { get; set; }

        [JsonPropertyName("VendorApplicationId")]
        public string VendorApplicationId { get; set; }
    }

    public partial class VriAdditionalInfo
    {
        [JsonPropertyName("@type")]
        public AdditionalInfoType Type { get; set; }

        [JsonPropertyName("FileValue")]
        public Vri FileValue { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("StringValue")]
        public string StringValue { get; set; }
    }

    public partial class Vri
    {
        [JsonPropertyName("@type")]
        public PurpleType Type { get; set; }

        [JsonPropertyName("Data")]
        public string Data { get; set; }

        [JsonPropertyName("FileName")]
        public string FileName { get; set; }

        [JsonPropertyName("MimeType")]
        public string MimeType { get; set; }
    }

    public partial class VriVoter
    {
        [JsonPropertyName("@type")]
        public SubjectType Type { get; set; }

        [JsonPropertyName("ContactMethod")]
        public List<VriContactMethod> ContactMethod { get; set; }

        [JsonPropertyName("DateOfBirth")]
        public DateTimeOffset? DateOfBirth { get; set; }

        [JsonPropertyName("Ethnicity")]
        public string Ethnicity { get; set; }

        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonPropertyName("MailingAddress")]
        public VriAddress MailingAddress { get; set; }

        [JsonPropertyName("Name")]
        public VriName Name { get; set; }

        [JsonPropertyName("Party")]
        public VriParty Party { get; set; }

        [JsonPropertyName("PreviousName")]
        public VriName PreviousName { get; set; }

        [JsonPropertyName("PreviousResidenceAddress")]
        public VriAddress PreviousResidenceAddress { get; set; }

        [JsonPropertyName("PreviousSignature")]
        public VriSignature PreviousSignature { get; set; }

        [JsonPropertyName("ResidenceAddress")]
        public VriAddress ResidenceAddress { get; set; }

        [JsonPropertyName("ResidenceAddressIsMailingAddress")]
        public bool? ResidenceAddressIsMailingAddress { get; set; }

        [JsonPropertyName("Signature")]
        public VriSignature Signature { get; set; }

        [JsonPropertyName("VoterClassification")]
        public List<VriVoterClassification> VoterClassification { get; set; }

        [JsonPropertyName("VoterId")]
        public List<VriVoterId> VoterId { get; set; }
    }

    public partial class VriContactMethod
    {
        [JsonPropertyName("@type")]
        public ContactMethodType Type { get; set; }

        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriContactMethodType VriContactMethodType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }

        [JsonPropertyName("Capability")]
        public List<VriPhoneCapability> Capability { get; set; }
    }

    public partial class VriName
    {
        [JsonPropertyName("@type")]
        public NameType Type { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("FullName")]
        public string FullName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("MiddleName")]
        public List<string> MiddleName { get; set; }

        [JsonPropertyName("Prefix")]
        public string Prefix { get; set; }

        [JsonPropertyName("Suffix")]
        public string Suffix { get; set; }
    }

    public partial class VriParty
    {
        [JsonPropertyName("@type")]
        public PartyType Type { get; set; }

        [JsonPropertyName("Abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("ExternalIdentifier")]
        public List<VriExternalIdentifier> ExternalIdentifier { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }

    public partial class VriExternalIdentifier
    {
        [JsonPropertyName("@type")]
        public ExternalIdentifierType Type { get; set; }

        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriIdentifierType VriExternalIdentifierType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class VriSignature
    {
        [JsonPropertyName("@type")]
        public PreviousSignatureType Type { get; set; }

        [JsonPropertyName("Date")]
        public DateTimeOffset? Date { get; set; }

        [JsonPropertyName("FileValue")]
        public VriImage FileValue { get; set; }

        [JsonPropertyName("OtherSource")]
        public string OtherSource { get; set; }

        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Source")]
        public VriSignatureSource? Source { get; set; }

        [JsonPropertyName("Type")]
        public VriSignatureType? VriSignatureType { get; set; }
    }

    public partial class VriImage
    {
        [JsonPropertyName("@type")]
        public FluffyType Type { get; set; }

        [JsonPropertyName("Data")]
        public string Data { get; set; }

        [JsonPropertyName("FileName")]
        public string FileName { get; set; }

        [JsonPropertyName("MimeType")]
        public string MimeType { get; set; }
    }

    public partial class VriVoterClassification
    {
        [JsonPropertyName("@type")]
        public VoterClassificationType Type { get; set; }

        [JsonPropertyName("Assertion")]
        public VriAssertionValue Assertion { get; set; }

        [JsonPropertyName("OtherAssertion")]
        public string OtherAssertion { get; set; }

        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("Type")]
        public VriVoterClassificationType VriVoterClassificationType { get; set; }
    }

    public partial class VriVoterId
    {
        [JsonPropertyName("@type")]
        public VoterIdType Type { get; set; }

        [JsonPropertyName("AttestNoSuchId")]
        public bool? AttestNoSuchId { get; set; }

        [JsonPropertyName("DateOfIssuance")]
        public DateTimeOffset? DateOfIssuance { get; set; }

        [JsonPropertyName("FileValue")]
        public Vri FileValue { get; set; }

        [JsonPropertyName("OtherType")]
        public string OtherType { get; set; }

        [JsonPropertyName("StringValue")]
        public string StringValue { get; set; }

        [JsonPropertyName("Type")]
        public VriVoterIdType VriVoterIdType { get; set; }
    }

    public partial class VriAddress
    {
        [JsonPropertyName("@type")]
        public VriAddressType Type { get; set; }

        [JsonPropertyName("CompleteAddressNumber")]
        public AddrTypeCompleteAddressNumberType CompleteAddressNumber { get; set; }

        [JsonPropertyName("CompleteStreetName")]
        public AddrTypeCompleteStreetNameType CompleteStreetName { get; set; }

        [JsonPropertyName("CompletePlaceName")]
        public AddrTypeCompletePlaceNameType CompletePlaceName { get; set; }

        [JsonPropertyName("StateName")]
        public string StateName { get; set; }

        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; set; }

        [JsonPropertyName("ZipPlus4")]
        public string ZipPlus4 { get; set; }

    }

 
    public partial class AddrTypeCompleteAddressNumberType
    {
        [JsonPropertyName("@type")]
        public CompleteAddressNumberType Type { get; set; }

        [JsonPropertyName("AddressNumber")]
        public string AddressNumber { get; set; }

    }

  

    public partial class AddrTypeCompletePlaceNameType
    {
        [JsonPropertyName("@type")]
        public CompletePlaceNameType Type { get; set; }

        [JsonPropertyName("PlaceName")]
        public List<AddrTypePlaceNameType> PlaceName { get; set; }

        [JsonPropertyName("Separator")]
        public string Separator { get; set; }
    }

    public partial class AddrTypePlaceNameType
    {
        [JsonPropertyName("@type")]
        public PlaceNameType Type { get; set; }

        [JsonPropertyName("ElementSequenceNumber")]
        public long? ElementSequenceNumber { get; set; }

        [JsonPropertyName("GNISFeatureID")]
        public long? GnisFeatureId { get; set; }

        [JsonPropertyName("PlaceNameType")]
        public AddrTypePlaceNameTypeType? PlaceNameType { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class AddrTypeCompleteStreetNameType
    {
        [JsonPropertyName("@type")]
        public CompleteStreetNameType Type { get; set; }

        [JsonPropertyName("AttachedElement")]
        public AddrTypeAttachedElementType? AttachedElement { get; set; }

        [JsonPropertyName("StreetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("StreetNamePostDirectional")]
        public AddrTypeStreetNamePreDirectionalType StreetNamePostDirectional { get; set; }


        [JsonPropertyName("StreetNamePostType")]
        public AddrTypeStreetNamePreTypeType StreetNamePostType { get; set; }

        [JsonPropertyName("StreetNamePreDirectional")]
        public AddrTypeStreetNamePreDirectionalType StreetNamePreDirectional { get; set; }

    }

    public partial class AddrTypeStreetNamePreDirectionalType
    {
        [JsonPropertyName("@type")]
        public StreetNamePostDirectionalType Type { get; set; }

        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }



    public partial class AddrTypeStreetNamePreTypeType
    {
        [JsonPropertyName("@type")]
        public StreetNamePostTypeType Type { get; set; }

        [JsonPropertyName("Separator")]
        public string Separator { get; set; }

        [JsonPropertyName("Value")]
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
