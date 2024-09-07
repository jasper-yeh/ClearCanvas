using System;

// This file is auto-generated
// ReSharper disable InconsistentNaming

namespace ClearCanvas.Dicom
{
    partial class DicomTags
    {
        /// <summary>
        /// <para>(0000,0800) Command Data Set Type</para>
        /// <para> VR: US VM:1</para>
        /// </summary>
        public const uint DataSetType = CommandDataSetType;
        /// <summary>
        /// <para>(0004,1504) MRDR Directory Record Offset</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint MrdrDirectoryRecordOffsetRetired = MrDrDirectoryRecordOffset;
        /// <summary>
        /// <para>(0004,1600) Number of References</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint NumberOfReferencesRetired = NumberOfReferences;
        /// <summary>
        /// <para>(0008,0001) Length to End</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint LengthToEndRetired = LengthToEnd;
        /// <summary>
        /// <para>(0008,0010) Recognition Code</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint RecognitionCodeRetired = RecognitionCode;
        /// <summary>
        /// <para>(0008,0024) Overlay Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayDateRetired = OverlayDate;
        /// <summary>
        /// <para>(0008,0025) Curve Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveDateRetired = CurveDate;
        /// <summary>
        /// <para>(0008,002A) Acquisition DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint AcquisitionDatetime = AcquisitionDateTime;
        /// <summary>
        /// <para>(0008,0034) Overlay Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayTimeRetired = OverlayTime;
        /// <summary>
        /// <para>(0008,0035) Curve Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint CurveTimeRetired = CurveTime;
        /// <summary>
        /// <para>(0008,0041) Data Set Subtype</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DataSetSubtypeRetired = DataSetSubtype;
        /// <summary>
        /// <para>(0008,0042) Nuclear Medicine Series Type</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint NuclearMedicineSeriesTypeRetired = NuclearMedicineSeriesType;
        /// <summary>
        /// <para>(0008,0090) Referring Physician's Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint ReferringPhysiciansName = ReferringPhysicianName;
        /// <summary>
        /// <para>(0008,0092) Referring Physician's Address</para>
        /// <para> VR: ST VM:1</para>
        /// </summary>
        public const uint ReferringPhysiciansAddress = ReferringPhysicianAddress;
        /// <summary>
        /// <para>(0008,0094) Referring Physician's Telephone Numbers</para>
        /// <para> VR: SH VM:1-n</para>
        /// </summary>
        public const uint ReferringPhysiciansTelephoneNumbers = ReferringPhysicianTelephoneNumbers;
        /// <summary>
        /// <para>(0008,1000) Network ID</para>
        /// <para> VR: AE VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint NetworkIdRetired = NetworkId;
        /// <summary>
        /// <para>(0008,1050) Performing Physician's Name</para>
        /// <para> VR: PN VM:1-n</para>
        /// </summary>
        public const uint PerformingPhysiciansName = PerformingPhysicianName;
        /// <summary>
        /// <para>(0008,1090) Manufacturer's Model Name</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint ManufacturersModelName = ManufacturerModelName;
        /// <summary>
        /// <para>(0008,1100) Referenced Results Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedResultsSequenceRetired = ReferencedResultsSequence;
        /// <summary>
        /// <para>(0008,1130) Referenced Overlay Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedOverlaySequenceRetired = ReferencedOverlaySequence;
        /// <summary>
        /// <para>(0008,1145) Referenced Curve Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedCurveSequenceRetired = ReferencedCurveSequence;
        /// <summary>
        /// <para>(0008,2200) Transducer Position</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint TransducerPositionRetired = TransducerPosition;
        /// <summary>
        /// <para>(0008,2204) Transducer Orientation</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint TransducerOrientationRetired = TransducerOrientation;
        /// <summary>
        /// <para>(0008,2208) Anatomic Structure</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint AnatomicStructureRetired = AnatomicStructure;
        /// <summary>
        /// <para>(0008,2240) Transducer Position Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TransducerPositionSequenceRetired = TransducerPositionSequence;
        /// <summary>
        /// <para>(0008,2242) Transducer Position Modifier Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TransducerPositionModifierSequenceRetired = TransducerPositionModifierSequence;
        /// <summary>
        /// <para>(0008,2244) Transducer Orientation Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TransducerOrientationSequenceRetired = TransducerOrientationSequence;
        /// <summary>
        /// <para>(0008,2246) Transducer Orientation Modifier Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TransducerOrientationModifierSequenceRetired = TransducerOrientationModifierSequence;
        /// <summary>
        /// <para>(0008,2251) Anatomic Structure Space Or Region Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicStructureSpaceOrRegionCodeSequenceTrialRetired = AnatomicStructureSpaceOrRegionCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,2253) Anatomic Portal Of Entrance Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicPortalOfEntranceCodeSequenceTrialRetired = AnatomicPortalOfEntranceCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,2255) Anatomic Approach Direction Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicApproachDirectionCodeSequenceTrialRetired = AnatomicApproachDirectionCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,2256) Anatomic Perspective Description (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicPerspectiveDescriptionTrialRetired = AnatomicPerspectiveDescriptionTrial;
        /// <summary>
        /// <para>(0008,2257) Anatomic Perspective Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicPerspectiveCodeSequenceTrialRetired = AnatomicPerspectiveCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,2258) Anatomic Location Of Examining Instrument Description (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicLocationOfExaminingInstrumentDescriptionTrialRetired = AnatomicLocationOfExaminingInstrumentDescriptionTrial;
        /// <summary>
        /// <para>(0008,2259) Anatomic Location Of Examining Instrument Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicLocationOfExaminingInstrumentCodeSequenceTrialRetired = AnatomicLocationOfExaminingInstrumentCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,225A) Anatomic Structure Space Or Region Modifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AnatomicStructureSpaceOrRegionModifierCodeSequenceTrialRetired = AnatomicStructureSpaceOrRegionModifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,225C) On Axis Background Anatomic Structure Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OnaxisBackgroundAnatomicStructureCodeSequenceTrialRetired = OnAxisBackgroundAnatomicStructureCodeSequenceTrial;
        /// <summary>
        /// <para>(0008,4000) Identifying Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint IdentifyingCommentsRetired = IdentifyingComments;
        /// <summary>
        /// <para>(0010,0010) Patient's Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint PatientsName = PatientName;
        /// <summary>
        /// <para>(0010,0030) Patient's Birth Date</para>
        /// <para> VR: DA VM:1</para>
        /// </summary>
        public const uint PatientsBirthDate = PatientBirthDate;
        /// <summary>
        /// <para>(0010,0032) Patient's Birth Time</para>
        /// <para> VR: TM VM:1</para>
        /// </summary>
        public const uint PatientsBirthTime = PatientBirthTime;
        /// <summary>
        /// <para>(0010,0040) Patient's Sex</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint PatientsSex = PatientSex;
        /// <summary>
        /// <para>(0010,0050) Patient's Insurance Plan Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint PatientsInsurancePlanCodeSequence = PatientInsurancePlanCodeSequence;
        /// <summary>
        /// <para>(0010,0101) Patient's Primary Language Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint PatientsPrimaryLanguageCodeSequence = PatientPrimaryLanguageCodeSequence;
        /// <summary>
        /// <para>(0010,0102) Patient's Primary Language Modifier Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint PatientsPrimaryLanguageModifierCodeSequence = PatientPrimaryLanguageModifierCodeSequence;
        /// <summary>
        /// <para>(0010,1005) Patient's Birth Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint PatientsBirthName = PatientBirthName;
        /// <summary>
        /// <para>(0010,1010) Patient's Age</para>
        /// <para> VR: AS VM:1</para>
        /// </summary>
        public const uint PatientsAge = PatientAge;
        /// <summary>
        /// <para>(0010,1020) Patient's Size</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint PatientsSize = PatientSize;
        /// <summary>
        /// <para>(0010,1021) Patient's Size Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint PatientsSizeCodeSequence = PatientSizeCodeSequence;
        /// <summary>
        /// <para>(0010,1030) Patient's Weight</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint PatientsWeight = PatientWeight;
        /// <summary>
        /// <para>(0010,1040) Patient's Address</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint PatientsAddress = PatientAddress;
        /// <summary>
        /// <para>(0010,1050) Insurance Plan Identification</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint InsurancePlanIdentificationRetired = InsurancePlanIdentification;
        /// <summary>
        /// <para>(0010,1060) Patient's Mother's Birth Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint PatientsMothersBirthName = PatientMotherBirthName;
        /// <summary>
        /// <para>(0010,2154) Patient's Telephone Numbers</para>
        /// <para> VR: SH VM:1-n</para>
        /// </summary>
        public const uint PatientsTelephoneNumbers = PatientTelephoneNumbers;
        /// <summary>
        /// <para>(0010,21F0) Patient's Religious Preference</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint PatientsReligiousPreference = PatientReligiousPreference;
        /// <summary>
        /// <para>(0010,2203) Patient's Sex Neutered</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint PatientsSexNeutered = PatientSexNeutered;
        /// <summary>
        /// <para>(0014,0044) Material Properties Description</para>
        /// <para> VR: ST VM:1</para>
        /// </summary>
        public const uint MaterialPropertiesFileId = MaterialPropertiesDescription;
        /// <summary>
        /// <para>(0014,0045) Material Properties File Format (Retired)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2011.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2011.")]
        public const uint MaterialPropertiesFileFormat = MaterialPropertiesFileFormatRetired;
        /// <summary>
        /// <para>(0014,4016) Element Pitch A</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint ElementPitch = ElementPitchA;
        /// <summary>
        /// <para>(0014,4058) Probe Center Location X</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint CrystalCenterLocationX = ProbeCenterLocationX;
        /// <summary>
        /// <para>(0014,4059) Probe Center Location Z</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint CrystalCenterLocationZ = ProbeCenterLocationZ;
        /// <summary>
        /// <para>(0018,0030) Radionuclide</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint RadionuclideRetired = Radionuclide;
        /// <summary>
        /// <para>(0018,0032) Energy Window Centerline</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint EnergyWindowCenterlineRetired = EnergyWindowCenterline;
        /// <summary>
        /// <para>(0018,0033) Energy Window Total Width</para>
        /// <para> VR: DS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint EnergyWindowTotalWidthRetired = EnergyWindowTotalWidth;
        /// <summary>
        /// <para>(0018,0037) Therapy Type</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TherapyTypeRetired = TherapyType;
        /// <summary>
        /// <para>(0018,0039) Therapy Description</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint TherapyDescriptionRetired = TherapyDescription;
        /// <summary>
        /// <para>(0018,1011) Hardcopy Creation Device ID</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint HardcopyCreationDeviceIdRetired = HardcopyCreationDeviceId;
        /// <summary>
        /// <para>(0018,1017) Hardcopy Device Manufacturer</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint HardcopyDeviceManufacturerRetired = HardcopyDeviceManufacturer;
        /// <summary>
        /// <para>(0018,1018) Secondary Capture Device Manufacturer's Model Name</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint SecondaryCaptureDeviceManufacturersModelName = SecondaryCaptureDeviceManufacturerModelName;
        /// <summary>
        /// <para>(0018,101A) Hardcopy Device Software Version</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint HardcopyDeviceSoftwareVersionRetired = HardcopyDeviceSoftwareVersion;
        /// <summary>
        /// <para>(0018,101B) Hardcopy Device Manufacturer's Model Name</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint HardcopyDeviceManufacturersModelNameRetired = HardcopyDeviceManufacturerModelName;
        /// <summary>
        /// <para>(0018,1078) Radiopharmaceutical Start DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint RadiopharmaceuticalStartDatetime = RadiopharmaceuticalStartDateTime;
        /// <summary>
        /// <para>(0018,1079) Radiopharmaceutical Stop DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint RadiopharmaceuticalStopDatetime = RadiopharmaceuticalStopDateTime;
        /// <summary>
        /// <para>(0018,1141) Angular Position</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AngularPositionRetired = AngularPosition;
        /// <summary>
        /// <para>(0018,1146) Rotation Offset</para>
        /// <para> VR: DS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint RotationOffsetRetired = RotationOffset;
        /// <summary>
        /// <para>(0018,1153) Exposure in µAs</para>
        /// <para> VR: IS VM:1</para>
        /// </summary>
        public const uint ExposureInUas = ExposureInuAs;
        /// <summary>
        /// <para>(0018,1240) Upper/Lower Pixel Values</para>
        /// <para> VR: IS VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint UpperLowerPixelValuesRetired = UpperLowerPixelValues;
        /// <summary>
        /// <para>(0018,1318) dB/dt</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint DbDt = dBdt;
        /// <summary>
        /// <para>(0018,1624) Shutter Presentation Color CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint ShutterPresentationColorCielabValue = ShutterPresentationColorCieLabValue;
        /// <summary>
        /// <para>(0018,4000) Acquisition Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint AcquisitionCommentsRetired = AcquisitionComments;
        /// <summary>
        /// <para>(0018,5021) Postprocessing Function</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PostprocessingFunctionRetired = PostprocessingFunction;
        /// <summary>
        /// <para>(0018,5030) Dynamic Range</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint DynamicRangeRetired = DynamicRange;
        /// <summary>
        /// <para>(0018,5040) Total Gain</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint TotalGainRetired = TotalGain;
        /// <summary>
        /// <para>(0018,5210) Image Transformation Matrix</para>
        /// <para> VR: DS VM:6</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint ImageTransformationMatrixRetired = ImageTransformationMatrix;
        /// <summary>
        /// <para>(0018,5212) Image Translation Vector</para>
        /// <para> VR: DS VM:3</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint ImageTranslationVectorRetired = ImageTranslationVector;
        /// <summary>
        /// <para>(0018,702B) Detector Manufacturer's Model Name</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint DetectorManufacturersModelName = DetectorManufacturerModelName;
        /// <summary>
        /// <para>(0018,8150) Exposure Time in µS</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint ExposureTimeInUs = ExposureTimeInuS;
        /// <summary>
        /// <para>(0018,8151) X-Ray Tube Current in µA</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint XRayTubeCurrentInUa = XRayTubeCurrentInuA;
        /// <summary>
        /// <para>(0018,9027) Spatial Pre-saturation</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint SpatialPreSaturation = SpatialPresaturation;
        /// <summary>
        /// <para>(0018,9059) De-coupling</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint DeCoupling = Decoupling;
        /// <summary>
        /// <para>(0018,9060) De-coupled Nucleus</para>
        /// <para> VR: CS VM:1-2</para>
        /// </summary>
        public const uint DeCoupledNucleus = DecoupledNucleus;
        /// <summary>
        /// <para>(0018,9061) De-coupling Frequency</para>
        /// <para> VR: FD VM:1-2</para>
        /// </summary>
        public const uint DeCouplingFrequency = DecouplingFrequency;
        /// <summary>
        /// <para>(0018,9062) De-coupling Method</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint DeCouplingMethod = DecouplingMethod;
        /// <summary>
        /// <para>(0018,9063) De-coupling Chemical Shift Reference</para>
        /// <para> VR: FD VM:1-2</para>
        /// </summary>
        public const uint DeCouplingChemicalShiftReference = DecouplingChemicalShiftReference;
        /// <summary>
        /// <para>(0018,9074) Frame Acquisition DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint FrameAcquisitionDatetime = FrameAcquisitionDateTime;
        /// <summary>
        /// <para>(0018,9151) Frame Reference DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint FrameReferenceDatetime = FrameReferenceDateTime;
        /// <summary>
        /// <para>(0018,9166) Bulk Motion Status</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BulkMotionStatusRetired = BulkMotionStatus;
        /// <summary>
        /// <para>(0018,9195) Chemical Shift Minimum Integration Limit in Hz</para>
        /// <para> VR: FD VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint ChemicalShiftMinimumIntegrationLimitInHzRetired = ChemicalShiftMinimumIntegrationLimitInHz;
        /// <summary>
        /// <para>(0018,9196) Chemical Shift Maximum Integration Limit in Hz</para>
        /// <para> VR: FD VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint ChemicalShiftMaximumIntegrationLimitInHzRetired = ChemicalShiftMaximumIntegrationLimitInHz;
        /// <summary>
        /// <para>(0018,925A) ASL Crusher Flow Limit</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint AslCrusherFlow = AslCrusherFlowLimit;
        /// <summary>
        /// <para>(0018,925C) ASL Bolus Cut-off Flag</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint AslBolusCutOffFlag = AslBolusCutoffFlag;
        /// <summary>
        /// <para>(0018,925D) ASL Bolus Cut-off Timing Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint AslBolusCutOffTimingSequence = AslBolusCutoffTimingSequence;
        /// <summary>
        /// <para>(0018,925E) ASL Bolus Cut-off Technique</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint AslBolusCutOffTechnique = AslBolusCutoffTechnique;
        /// <summary>
        /// <para>(0018,925F) ASL Bolus Cut-off Delay Time</para>
        /// <para> VR: UL VM:1</para>
        /// </summary>
        public const uint AslBolusCutOffDelayTime = AslBolusCutoffDelayTime;
        /// <summary>
        /// <para>(0018,9295) Chemical Shift Minimum Integration Limit in ppm</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint ChemicalShiftMinimumIntegrationLimitInPpm = ChemicalShiftMinimumIntegrationLimitInppm;
        /// <summary>
        /// <para>(0018,9296) Chemical Shift Maximum Integration Limit in ppm</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint ChemicalShiftMaximumIntegrationLimitInPpm = ChemicalShiftMaximumIntegrationLimitInppm;
        /// <summary>
        /// <para>(0018,9328) Exposure Time in ms</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint ExposureTimeInMs = ExposureTimeInms;
        /// <summary>
        /// <para>(0018,9330) X-Ray Tube Current in mA</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint XRayTubeCurrentInMa = XRayTubeCurrentInmA;
        /// <summary>
        /// <para>(0018,9332) Exposure in mAs</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint ExposureInMas = ExposureInmAs;
        /// <summary>
        /// <para>(0018,9345) CTDIvol</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint Ctdivol = CtDIvol;
        /// <summary>
        /// <para>(0018,9346) CTDI Phantom Type Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint CtdiPhantomTypeCodeSequence = CtDiPhantomTypeCodeSequence;
        /// <summary>
        /// <para>(0018,9504) X-Ray 3D Frame Type Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint XRay3dFrameTypeSequence = XRay3DFrameTypeSequence;
        /// <summary>
        /// <para>(0018,9507) X-Ray 3D Acquisition Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint XRay3dAcquisitionSequence = XRay3DAcquisitionSequence;
        /// <summary>
        /// <para>(0018,9516) Start Acquisition DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint StartAcquisitionDatetime = StartAcquisitionDateTime;
        /// <summary>
        /// <para>(0018,9517) End Acquisition DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint EndAcquisitionDatetime = EndAcquisitionDateTime;
        /// <summary>
        /// <para>(0018,9530) X-Ray 3D Reconstruction Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint XRay3dReconstructionSequence = XRay3DReconstructionSequence;
        /// <summary>
        /// <para>(0018,9701) Decay Correction DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint DecayCorrectionDatetime = DecayCorrectionDateTime;
        /// <summary>
        /// <para>(0018,9804) Exclusion Start DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ExclusionStartDatetime = ExclusionStartDateTime;
        /// <summary>
        /// <para>(0020,0014) Isotope Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint IsotopeNumberRetired = IsotopeNumber;
        /// <summary>
        /// <para>(0020,0015) Phase Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint PhaseNumberRetired = PhaseNumber;
        /// <summary>
        /// <para>(0020,0016) Interval Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint IntervalNumberRetired = IntervalNumber;
        /// <summary>
        /// <para>(0020,0017) Time Slot Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint TimeSlotNumberRetired = TimeSlotNumber;
        /// <summary>
        /// <para>(0020,0018) Angle Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1993.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1993.")]
        public const uint AngleNumberRetired = AngleNumber;
        /// <summary>
        /// <para>(0020,0022) Overlay Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayNumberRetired = OverlayNumber;
        /// <summary>
        /// <para>(0020,0024) Curve Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveNumberRetired = CurveNumber;
        /// <summary>
        /// <para>(0020,0026) LUT Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint LutNumberRetired = LutNumber;
        /// <summary>
        /// <para>(0020,0030) Image Position</para>
        /// <para> VR: DS VM:3</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImagePositionRetired = ImagePosition;
        /// <summary>
        /// <para>(0020,0035) Image Orientation</para>
        /// <para> VR: DS VM:6</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImageOrientationRetired = ImageOrientation;
        /// <summary>
        /// <para>(0020,0050) Location</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint LocationRetired = Location;
        /// <summary>
        /// <para>(0020,0070) Image Geometry Type</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImageGeometryTypeRetired = ImageGeometryType;
        /// <summary>
        /// <para>(0020,0080) Masking Image</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint MaskingImageRetired = MaskingImage;
        /// <summary>
        /// <para>(0020,00AA) Report Number</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReportNumberRetired = ReportNumber;
        /// <summary>
        /// <para>(0020,1000) Series in Study</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint SeriesInStudyRetired = SeriesInStudy;
        /// <summary>
        /// <para>(0020,1001) Acquisitions in Series</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint AcquisitionsInSeriesRetired = AcquisitionsInSeries;
        /// <summary>
        /// <para>(0020,1003) Images in Series</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2006.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2006.")]
        public const uint ImagesInSeriesRetired = ImagesInSeries;
        /// <summary>
        /// <para>(0020,1004) Acquisitions in Study</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AcquisitionsInStudyRetired = AcquisitionsInStudy;
        /// <summary>
        /// <para>(0020,1005) Images in Study</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2006.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2006.")]
        public const uint ImagesInStudyRetired = ImagesInStudy;
        /// <summary>
        /// <para>(0020,1020) Reference</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ReferenceRetired = Reference;
        /// <summary>
        /// <para>(0020,1070) Other Study Numbers</para>
        /// <para> VR: IS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OtherStudyNumbersRetired = OtherStudyNumbers;
        /// <summary>
        /// <para>(0020,31xx) Source Image IDs</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint SourceImageIdsRetired = SourceImageIds;
        /// <summary>
        /// <para>(0020,3401) Modifying Device ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifyingDeviceIdRetired = ModifyingDeviceId;
        /// <summary>
        /// <para>(0020,3402) Modified Image ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifiedImageIdRetired = ModifiedImageId;
        /// <summary>
        /// <para>(0020,3403) Modified Image Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifiedImageDateRetired = ModifiedImageDate;
        /// <summary>
        /// <para>(0020,3404) Modifying Device Manufacturer</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifyingDeviceManufacturerRetired = ModifyingDeviceManufacturer;
        /// <summary>
        /// <para>(0020,3405) Modified Image Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifiedImageTimeRetired = ModifiedImageTime;
        /// <summary>
        /// <para>(0020,3406) Modified Image Description</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ModifiedImageDescriptionRetired = ModifiedImageDescription;
        /// <summary>
        /// <para>(0020,5000) Original Image Identification</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OriginalImageIdentificationRetired = OriginalImageIdentification;
        /// <summary>
        /// <para>(0020,5002) Original Image Identification Nomenclature</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OriginalImageIdentificationNomenclatureRetired = OriginalImageIdentificationNomenclature;
        /// <summary>
        /// <para>(0022,1044) Ophthalmic Ultrasound Method Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint OphthalmicUltrasoundAxialMeasurementsTypeCodeSequence = OphthalmicUltrasoundMethodCodeSequence;
        /// <summary>
        /// <para>(0022,1135) Source of Refractive Measurements Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint SourceOfRefractiveErrorDataCodeSequence = SourceOfRefractiveMeasurementsCodeSequence;
        /// <summary>
        /// <para>(0024,0044) Comments on Patient's Performance of Visual Field</para>
        /// <para> VR: LT VM:1</para>
        /// </summary>
        public const uint CommentsOnPatientsPerformanceOfVisualField = CommentsOnPatientPerformanceOfVisualField;
        /// <summary>
        /// <para>(0028,0005) Image Dimensions</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImageDimensionsRetired = ImageDimensions;
        /// <summary>
        /// <para>(0028,0012) Planes</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PlanesRetired = Planes;
        /// <summary>
        /// <para>(0028,0040) Image Format</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImageFormatRetired = ImageFormat;
        /// <summary>
        /// <para>(0028,0050) Manipulated Image</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ManipulatedImageRetired = ManipulatedImage;
        /// <summary>
        /// <para>(0028,005F) Compression Recognition Code</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionRecognitionCodeRetired = CompressionRecognitionCode;
        /// <summary>
        /// <para>(0028,0060) Compression Code</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint CompressionCodeRetired = CompressionCode;
        /// <summary>
        /// <para>(0028,0061) Compression Originator</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionOriginatorRetired = CompressionOriginator;
        /// <summary>
        /// <para>(0028,0062) Compression Label</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionLabelRetired = CompressionLabel;
        /// <summary>
        /// <para>(0028,0063) Compression Description</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionDescriptionRetired = CompressionDescription;
        /// <summary>
        /// <para>(0028,0065) Compression Sequence</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionSequenceRetired = CompressionSequence;
        /// <summary>
        /// <para>(0028,0066) Compression Step Pointers</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CompressionStepPointersRetired = CompressionStepPointers;
        /// <summary>
        /// <para>(0028,0068) Repeat Interval</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint RepeatIntervalRetired = RepeatInterval;
        /// <summary>
        /// <para>(0028,0069) Bits Grouped</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BitsGroupedRetired = BitsGrouped;
        /// <summary>
        /// <para>(0028,0070) Perimeter Table</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PerimeterTableRetired = PerimeterTable;
        /// <summary>
        /// <para>(0028,0071) Perimeter Value</para>
        /// <para> VR: US or SS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PerimeterValueRetired = PerimeterValue;
        /// <summary>
        /// <para>(0028,0080) Predictor Rows</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PredictorRowsRetired = PredictorRows;
        /// <summary>
        /// <para>(0028,0081) Predictor Columns</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PredictorColumnsRetired = PredictorColumns;
        /// <summary>
        /// <para>(0028,0082) Predictor Constants</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PredictorConstantsRetired = PredictorConstants;
        /// <summary>
        /// <para>(0028,0090) Blocked Pixels</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BlockedPixelsRetired = BlockedPixels;
        /// <summary>
        /// <para>(0028,0091) Block Rows</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BlockRowsRetired = BlockRows;
        /// <summary>
        /// <para>(0028,0092) Block Columns</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BlockColumnsRetired = BlockColumns;
        /// <summary>
        /// <para>(0028,0093) Row Overlap</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint RowOverlapRetired = RowOverlap;
        /// <summary>
        /// <para>(0028,0094) Column Overlap</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint ColumnOverlapRetired = ColumnOverlap;
        /// <summary>
        /// <para>(0028,0104) Smallest Valid Pixel Value</para>
        /// <para> VR: US or SS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint SmallestValidPixelValueRetired = SmallestValidPixelValue;
        /// <summary>
        /// <para>(0028,0105) Largest Valid Pixel Value</para>
        /// <para> VR: US or SS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint LargestValidPixelValueRetired = LargestValidPixelValue;
        /// <summary>
        /// <para>(0028,0110) Smallest Image Pixel Value in Plane</para>
        /// <para> VR: US or SS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint SmallestImagePixelValueInPlaneRetired = SmallestImagePixelValueInPlane;
        /// <summary>
        /// <para>(0028,0111) Largest Image Pixel Value in Plane</para>
        /// <para> VR: US or SS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargestImagePixelValueInPlaneRetired = LargestImagePixelValueInPlane;
        /// <summary>
        /// <para>(0028,0200) Image Location</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImageLocationRetired = ImageLocation;
        /// <summary>
        /// <para>(0028,0400) Transform Label</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TransformLabelRetired = TransformLabel;
        /// <summary>
        /// <para>(0028,0401) Transform Version Number</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TransformVersionNumberRetired = TransformVersionNumber;
        /// <summary>
        /// <para>(0028,0402) Number of Transform Steps</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint NumberOfTransformStepsRetired = NumberOfTransformSteps;
        /// <summary>
        /// <para>(0028,0403) Sequence of Compressed Data</para>
        /// <para> VR: LO VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint SequenceOfCompressedDataRetired = SequenceOfCompressedData;
        /// <summary>
        /// <para>(0028,0404) Details of Coefficients</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DetailsOfCoefficientsRetired = DetailsOfCoefficients;
        /// <summary>
        /// <para>(0028,0700) DCT Label</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DctLabelRetired = DctLabel;
        /// <summary>
        /// <para>(0028,0701) Data Block Description</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DataBlockDescriptionRetired = DataBlockDescription;
        /// <summary>
        /// <para>(0028,0702) Data Block</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DataBlockRetired = DataBlock;
        /// <summary>
        /// <para>(0028,0710) Normalization Factor Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint NormalizationFactorFormatRetired = NormalizationFactorFormat;
        /// <summary>
        /// <para>(0028,0720) Zonal Map Number Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint ZonalMapNumberFormatRetired = ZonalMapNumberFormat;
        /// <summary>
        /// <para>(0028,0721) Zonal Map Location</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint ZonalMapLocationRetired = ZonalMapLocation;
        /// <summary>
        /// <para>(0028,0722) Zonal Map Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint ZonalMapFormatRetired = ZonalMapFormat;
        /// <summary>
        /// <para>(0028,0730) Adaptive Map Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint AdaptiveMapFormatRetired = AdaptiveMapFormat;
        /// <summary>
        /// <para>(0028,0740) Code Number Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CodeNumberFormatRetired = CodeNumberFormat;
        /// <summary>
        /// <para>(0028,1080) Gray Scale</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint GrayScaleRetired = GrayScale;
        /// <summary>
        /// <para>(0028,1100) Gray Lookup Table Descriptor</para>
        /// <para> VR: US or SS VM:3</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint GrayLookupTableDescriptorRetired = GrayLookupTableDescriptor;
        /// <summary>
        /// <para>(0028,1111) Large Red Palette Color Lookup Table Descriptor</para>
        /// <para> VR: US or SS VM:4</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeRedPaletteColorLookupTableDescriptorRetired = LargeRedPaletteColorLookupTableDescriptor;
        /// <summary>
        /// <para>(0028,1112) Large Green Palette Color Lookup Table Descriptor</para>
        /// <para> VR: US or SS VM:4</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeGreenPaletteColorLookupTableDescriptorRetired = LargeGreenPaletteColorLookupTableDescriptor;
        /// <summary>
        /// <para>(0028,1113) Large Blue Palette Color Lookup Table Descriptor</para>
        /// <para> VR: US or SS VM:4</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeBluePaletteColorLookupTableDescriptorRetired = LargeBluePaletteColorLookupTableDescriptor;
        /// <summary>
        /// <para>(0028,1200) Gray Lookup Table Data</para>
        /// <para> VR: US or SS or OW VM:1-n or 1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint GrayLookupTableDataRetired = GrayLookupTableData;
        /// <summary>
        /// <para>(0028,1211) Large Red Palette Color Lookup Table Data</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeRedPaletteColorLookupTableDataRetired = LargeRedPaletteColorLookupTableData;
        /// <summary>
        /// <para>(0028,1212) Large Green Palette Color Lookup Table Data</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeGreenPaletteColorLookupTableDataRetired = LargeGreenPaletteColorLookupTableData;
        /// <summary>
        /// <para>(0028,1213) Large Blue Palette Color Lookup Table Data</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargeBluePaletteColorLookupTableDataRetired = LargeBluePaletteColorLookupTableData;
        /// <summary>
        /// <para>(0028,1214) Large Palette Color Lookup Table UID</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint LargePaletteColorLookupTableUidRetired = LargePaletteColorLookupTableUid;
        /// <summary>
        /// <para>(0028,1404) Blending LUT 1 Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint BlendingLut1Sequence = BlendingLuT1Sequence;
        /// <summary>
        /// <para>(0028,1405) Blending LUT 1 Transfer Function</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint BlendingLut1TransferFunction = BlendingLuT1TransferFunction;
        /// <summary>
        /// <para>(0028,140C) Blending LUT 2 Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint BlendingLut2Sequence = BlendingLuT2Sequence;
        /// <summary>
        /// <para>(0028,140D) Blending LUT 2 Transfer Function</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint BlendingLut2TransferFunction = BlendingLuT2TransferFunction;
        /// <summary>
        /// <para>(0028,140F) RGB LUT Transfer Function</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint RgbLutTransferFunction = RgblutTransferFunction;
        /// <summary>
        /// <para>(0028,4000) Image Presentation Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ImagePresentationCommentsRetired = ImagePresentationComments;
        /// <summary>
        /// <para>(0028,5000) Bi-Plane Acquisition Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint BiPlaneAcquisitionSequenceRetired = BiPlaneAcquisitionSequence;
        /// <summary>
        /// <para>(0028,6020) Frame Numbers of Interest (FOI)</para>
        /// <para> VR: US VM:1-n</para>
        /// </summary>
        public const uint FrameNumbersOfInterestFoi = FrameNumbersOfInterest;
        /// <summary>
        /// <para>(0028,6030) Mask Pointer(s)</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint MaskPointersRetired = MaskPointers;
        /// <summary>
        /// <para>(0028,9099) Largest Monochrome Pixel Value</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint LargestMonochromePixelValueRetired = LargestMonochromePixelValue;
        /// <summary>
        /// <para>(0032,000A) Study Status ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyStatusIdRetired = StudyStatusId;
        /// <summary>
        /// <para>(0032,000C) Study Priority ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyPriorityIdRetired = StudyPriorityId;
        /// <summary>
        /// <para>(0032,0012) Study ID Issuer</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyIdIssuerRetired = StudyIdIssuer;
        /// <summary>
        /// <para>(0032,0032) Study Verified Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyVerifiedDateRetired = StudyVerifiedDate;
        /// <summary>
        /// <para>(0032,0033) Study Verified Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyVerifiedTimeRetired = StudyVerifiedTime;
        /// <summary>
        /// <para>(0032,0034) Study Read Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyReadDateRetired = StudyReadDate;
        /// <summary>
        /// <para>(0032,0035) Study Read Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyReadTimeRetired = StudyReadTime;
        /// <summary>
        /// <para>(0032,1000) Scheduled Study Start Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyStartDateRetired = ScheduledStudyStartDate;
        /// <summary>
        /// <para>(0032,1001) Scheduled Study Start Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyStartTimeRetired = ScheduledStudyStartTime;
        /// <summary>
        /// <para>(0032,1010) Scheduled Study Stop Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyStopDateRetired = ScheduledStudyStopDate;
        /// <summary>
        /// <para>(0032,1011) Scheduled Study Stop Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyStopTimeRetired = ScheduledStudyStopTime;
        /// <summary>
        /// <para>(0032,1020) Scheduled Study Location</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyLocationRetired = ScheduledStudyLocation;
        /// <summary>
        /// <para>(0032,1021) Scheduled Study Location AE Title</para>
        /// <para> VR: AE VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledStudyLocationAeTitleRetired = ScheduledStudyLocationAeTitle;
        /// <summary>
        /// <para>(0032,1030) Reason for Study</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReasonForStudyRetired = ReasonForStudy;
        /// <summary>
        /// <para>(0032,1040) Study Arrival Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyArrivalDateRetired = StudyArrivalDate;
        /// <summary>
        /// <para>(0032,1041) Study Arrival Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyArrivalTimeRetired = StudyArrivalTime;
        /// <summary>
        /// <para>(0032,1050) Study Completion Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyCompletionDateRetired = StudyCompletionDate;
        /// <summary>
        /// <para>(0032,1051) Study Completion Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyCompletionTimeRetired = StudyCompletionTime;
        /// <summary>
        /// <para>(0032,1055) Study Component Status ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint StudyComponentStatusIdRetired = StudyComponentStatusId;
        /// <summary>
        /// <para>(0032,4000) Study Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint StudyCommentsRetired = StudyComments;
        /// <summary>
        /// <para>(0038,0011) Issuer of Admission ID</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2008.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2008.")]
        public const uint IssuerOfAdmissionIdRetired = IssuerOfAdmissionId;
        /// <summary>
        /// <para>(0038,001A) Scheduled Admission Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledAdmissionDateRetired = ScheduledAdmissionDate;
        /// <summary>
        /// <para>(0038,001B) Scheduled Admission Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledAdmissionTimeRetired = ScheduledAdmissionTime;
        /// <summary>
        /// <para>(0038,001C) Scheduled Discharge Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledDischargeDateRetired = ScheduledDischargeDate;
        /// <summary>
        /// <para>(0038,001D) Scheduled Discharge Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledDischargeTimeRetired = ScheduledDischargeTime;
        /// <summary>
        /// <para>(0038,001E) Scheduled Patient Institution Residence</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ScheduledPatientInstitutionResidenceRetired = ScheduledPatientInstitutionResidence;
        /// <summary>
        /// <para>(0038,0030) Discharge Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DischargeDateRetired = DischargeDate;
        /// <summary>
        /// <para>(0038,0032) Discharge Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DischargeTimeRetired = DischargeTime;
        /// <summary>
        /// <para>(0038,0040) Discharge Diagnosis Description</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DischargeDiagnosisDescriptionRetired = DischargeDiagnosisDescription;
        /// <summary>
        /// <para>(0038,0044) Discharge Diagnosis Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DischargeDiagnosisCodeSequenceRetired = DischargeDiagnosisCodeSequence;
        /// <summary>
        /// <para>(0038,0061) Issuer of Service Episode ID</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2008.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2008.")]
        public const uint IssuerOfServiceEpisodeIdRetired = IssuerOfServiceEpisodeId;
        /// <summary>
        /// <para>(0038,0400) Patient's Institution Residence</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint PatientsInstitutionResidence = PatientInstitutionResidence;
        /// <summary>
        /// <para>(003A,0231) Waveform Display Background CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint WaveformDisplayBackgroundCielabValue = WaveformDisplayBackgroundCieLabValue;
        /// <summary>
        /// <para>(003A,0244) Channel Recommended Display CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint ChannelRecommendedDisplayCielabValue = ChannelRecommendedDisplayCieLabValue;
        /// <summary>
        /// <para>(0040,0006) Scheduled Performing Physician's Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint ScheduledPerformingPhysiciansName = ScheduledPerformingPhysicianName;
        /// <summary>
        /// <para>(0040,0307) Distance Source to Support</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint DistanceSourceToSupportRetired = DistanceSourceToSupport;
        /// <summary>
        /// <para>(0040,0330) Referenced Procedure Step Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint ReferencedProcedureStepSequenceRetired = ReferencedProcedureStepSequence;
        /// <summary>
        /// <para>(0040,050A) Specimen Accession Number</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2008.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2008.")]
        public const uint SpecimenAccessionNumberRetired = SpecimenAccessionNumber;
        /// <summary>
        /// <para>(0040,0550) Specimen Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2008.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2008.")]
        public const uint SpecimenSequenceRetired = SpecimenSequence;
        /// <summary>
        /// <para>(0040,0552) Specimen Description Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint SpecimenDescriptionSequenceTrialRetired = SpecimenDescriptionSequenceTrial;
        /// <summary>
        /// <para>(0040,0553) Specimen Description (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint SpecimenDescriptionTrialRetired = SpecimenDescriptionTrial;
        /// <summary>
        /// <para>(0040,06FA) Slide Identifier</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2008.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2008.")]
        public const uint SlideIdentifierRetired = SlideIdentifier;
        /// <summary>
        /// <para>(0040,08D8) Pixel Spacing Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint PixelSpacingSequenceRetired = PixelSpacingSequence;
        /// <summary>
        /// <para>(0040,08DA) Coordinate System Axis Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint CoordinateSystemAxisCodeSequenceRetired = CoordinateSystemAxisCodeSequence;
        /// <summary>
        /// <para>(0040,09F8) Vital Stain Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VitalStainCodeSequenceTrialRetired = VitalStainCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,1006) Placer Order Number / Procedure</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint PlacerOrderNumberProcedureRetired = PlacerOrderNumberProcedure;
        /// <summary>
        /// <para>(0040,1007) Filler Order Number / Procedure</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint FillerOrderNumberProcedureRetired = FillerOrderNumberProcedure;
        /// <summary>
        /// <para>(0040,1060) Requested Procedure Description (Trial)</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint RequestedProcedureDescriptionTrialRetired = RequestedProcedureDescriptionTrial;
        /// <summary>
        /// <para>(0040,1102) Person's Address</para>
        /// <para> VR: ST VM:1</para>
        /// </summary>
        public const uint PersonsAddress = PersonAddress;
        /// <summary>
        /// <para>(0040,1103) Person's Telephone Numbers</para>
        /// <para> VR: LO VM:1-n</para>
        /// </summary>
        public const uint PersonsTelephoneNumbers = PersonTelephoneNumbers;
        /// <summary>
        /// <para>(0040,2001) Reason for the Imaging Service Request</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2003.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2003.")]
        public const uint ReasonForTheImagingServiceRequestRetired = ReasonForTheImagingServiceRequest;
        /// <summary>
        /// <para>(0040,2009) Order Enterer's Location</para>
        /// <para> VR: SH VM:1</para>
        /// </summary>
        public const uint OrderEnterersLocation = OrderEntererLocation;
        /// <summary>
        /// <para>(0040,4005) Scheduled Procedure Step Start DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ScheduledProcedureStepStartDatetime = ScheduledProcedureStepStartDateTime;
        /// <summary>
        /// <para>(0040,4036) Human Performer's Organization</para>
        /// <para> VR: LO VM:1</para>
        /// </summary>
        public const uint HumanPerformersOrganization = HumanPerformerOrganization;
        /// <summary>
        /// <para>(0040,4037) Human Performer's Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint HumanPerformersName = HumanPerformerName;
        /// <summary>
        /// <para>(0040,4050) Performed Procedure Step Start DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint PerformedProcedureStepStartDatetime = PerformedProcedureStepStartDateTime;
        /// <summary>
        /// <para>(0040,4051) Performed Procedure Step End DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint PerformedProcedureStepEndDatetime = PerformedProcedureStepEndDateTime;
        /// <summary>
        /// <para>(0040,4052) Procedure Step Cancellation DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ProcedureStepCancellationDatetime = ProcedureStepCancellationDateTime;
        /// <summary>
        /// <para>(0040,8302) Entrance Dose in mGy</para>
        /// <para> VR: DS VM:1</para>
        /// </summary>
        public const uint EntranceDoseInMgy = EntranceDoseInmGy;
        /// <summary>
        /// <para>(0040,A007) Findings Flag (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsFlagTrialRetired = FindingsFlagTrial;
        /// <summary>
        /// <para>(0040,A020) Findings Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsSequenceTrialRetired = FindingsSequenceTrial;
        /// <summary>
        /// <para>(0040,A021) Findings Group UID (Trial)</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsGroupUidTrialRetired = FindingsGroupUidTrial;
        /// <summary>
        /// <para>(0040,A022) Referenced Findings Group UID (Trial)</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReferencedFindingsGroupUidTrialRetired = ReferencedFindingsGroupUidTrial;
        /// <summary>
        /// <para>(0040,A023) Findings Group Recording Date (Trial)</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsGroupRecordingDateTrialRetired = FindingsGroupRecordingDateTrial;
        /// <summary>
        /// <para>(0040,A024) Findings Group Recording Time (Trial)</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsGroupRecordingTimeTrialRetired = FindingsGroupRecordingTimeTrial;
        /// <summary>
        /// <para>(0040,A026) Findings Source Category Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint FindingsSourceCategoryCodeSequenceTrialRetired = FindingsSourceCategoryCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A028) Documenting Organization Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DocumentingOrganizationIdentifierCodeSequenceTrialRetired = DocumentingOrganizationIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A047) Measurement Precision Description (Trial)</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint MeasurementPrecisionDescriptionTrialRetired = MeasurementPrecisionDescriptionTrial;
        /// <summary>
        /// <para>(0040,A057) Urgency or Priority Alerts (Trial)</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint UrgencyOrPriorityAlertsTrialRetired = UrgencyOrPriorityAlertsTrial;
        /// <summary>
        /// <para>(0040,A060) Sequencing Indicator (Trial)</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint SequencingIndicatorTrialRetired = SequencingIndicatorTrial;
        /// <summary>
        /// <para>(0040,A066) Document Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DocumentIdentifierCodeSequenceTrialRetired = DocumentIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A067) Document Author (Trial)</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DocumentAuthorTrialRetired = DocumentAuthorTrial;
        /// <summary>
        /// <para>(0040,A068) Document Author Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DocumentAuthorIdentifierCodeSequenceTrialRetired = DocumentAuthorIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A070) Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint IdentifierCodeSequenceTrialRetired = IdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A074) Object Binary Identifier (Trial)</para>
        /// <para> VR: OB VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObjectBinaryIdentifierTrialRetired = ObjectBinaryIdentifierTrial;
        /// <summary>
        /// <para>(0040,A076) Documenting Observer Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DocumentingObserverIdentifierCodeSequenceTrialRetired = DocumentingObserverIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A082) Participation DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ParticipationDatetime = ParticipationDateTime;
        /// <summary>
        /// <para>(0040,A085) Procedure Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ProcedureIdentifierCodeSequenceTrialRetired = ProcedureIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A089) Object Directory Binary Identifier (Trial)</para>
        /// <para> VR: OB VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObjectDirectoryBinaryIdentifierTrialRetired = ObjectDirectoryBinaryIdentifierTrial;
        /// <summary>
        /// <para>(0040,A090) Equivalent CDA Document Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2006.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2006.")]
        public const uint EquivalentCdaDocumentSequenceRetired = EquivalentCdaDocumentSequence;
        /// <summary>
        /// <para>(0040,A110) Date of Document or Verbal Transaction (Trial)</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DateOfDocumentOrVerbalTransactionTrialRetired = DateOfDocumentOrVerbalTransactionTrial;
        /// <summary>
        /// <para>(0040,A112) Time of Document Creation or Verbal Transaction (Trial)</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint TimeOfDocumentCreationOrVerbalTransactionTrialRetired = TimeOfDocumentCreationOrVerbalTransactionTrial;
        /// <summary>
        /// <para>(0040,A120) DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint Datetime = DateTime;
        /// <summary>
        /// <para>(0040,A125) Report Status ID (Trial)</para>
        /// <para> VR: CS VM:2</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReportStatusIdTrialRetired = ReportStatusIdTrial;
        /// <summary>
        /// <para>(0040,A13A) Referenced DateTime</para>
        /// <para> VR: DT VM:1-n</para>
        /// </summary>
        public const uint ReferencedDatetime = ReferencedDateTime;
        /// <summary>
        /// <para>(0040,A167) Observation Category Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationCategoryCodeSequenceTrialRetired = ObservationCategoryCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A16A) Bibliographic Citation (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint BibliographicCitationTrialRetired = BibliographicCitationTrial;
        /// <summary>
        /// <para>(0040,A171) Observation UID</para>
        /// <para> VR: UI VM:1</para>
        /// </summary>
        public const uint ObservationUidTrialRetired = ObservationUid;
        /// <summary>
        /// <para>(0040,A172) Referenced Observation UID (Trial)</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReferencedObservationUidTrialRetired = ReferencedObservationUidTrial;
        /// <summary>
        /// <para>(0040,A173) Referenced Observation Class (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReferencedObservationClassTrialRetired = ReferencedObservationClassTrial;
        /// <summary>
        /// <para>(0040,A174) Referenced Object Observation Class (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReferencedObjectObservationClassTrialRetired = ReferencedObjectObservationClassTrial;
        /// <summary>
        /// <para>(0040,A192) Observation Date (Trial)</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationDateTrialRetired = ObservationDateTrial;
        /// <summary>
        /// <para>(0040,A193) Observation Time (Trial)</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationTimeTrialRetired = ObservationTimeTrial;
        /// <summary>
        /// <para>(0040,A194) Measurement Automation (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint MeasurementAutomationTrialRetired = MeasurementAutomationTrial;
        /// <summary>
        /// <para>(0040,A224) Identification Description (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint IdentificationDescriptionTrialRetired = IdentificationDescriptionTrial;
        /// <summary>
        /// <para>(0040,A290) Coordinates Set Geometric Type (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint CoordinatesSetGeometricTypeTrialRetired = CoordinatesSetGeometricTypeTrial;
        /// <summary>
        /// <para>(0040,A296) Algorithm Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint AlgorithmCodeSequenceTrialRetired = AlgorithmCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A297) Algorithm Description (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint AlgorithmDescriptionTrialRetired = AlgorithmDescriptionTrial;
        /// <summary>
        /// <para>(0040,A29A) Pixel Coordinates Set (Trial)</para>
        /// <para> VR: SL VM:2-2n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint PixelCoordinatesSetTrialRetired = PixelCoordinatesSetTrial;
        /// <summary>
        /// <para>(0040,A307) Current Observer (Trial)</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint CurrentObserverTrialRetired = CurrentObserverTrial;
        /// <summary>
        /// <para>(0040,A313) Referenced Accession Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReferencedAccessionSequenceTrialRetired = ReferencedAccessionSequenceTrial;
        /// <summary>
        /// <para>(0040,A33A) Report Status Comment (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReportStatusCommentTrialRetired = ReportStatusCommentTrial;
        /// <summary>
        /// <para>(0040,A340) Procedure Context Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ProcedureContextSequenceTrialRetired = ProcedureContextSequenceTrial;
        /// <summary>
        /// <para>(0040,A352) Verbal Source (Trial)</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint VerbalSourceTrialRetired = VerbalSourceTrial;
        /// <summary>
        /// <para>(0040,A353) Address (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint AddressTrialRetired = AddressTrial;
        /// <summary>
        /// <para>(0040,A354) Telephone Number (Trial)</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint TelephoneNumberTrialRetired = TelephoneNumberTrial;
        /// <summary>
        /// <para>(0040,A358) Verbal Source Identifier Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint VerbalSourceIdentifierCodeSequenceTrialRetired = VerbalSourceIdentifierCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A380) Report Detail Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReportDetailSequenceTrialRetired = ReportDetailSequenceTrial;
        /// <summary>
        /// <para>(0040,A390) HL7 Structured Document Reference Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint Hl7StructuredDocumentReferenceSequence = HL7StructuredDocumentReferenceSequence;
        /// <summary>
        /// <para>(0040,A402) Observation Subject UID (Trial)</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationSubjectUidTrialRetired = ObservationSubjectUidTrial;
        /// <summary>
        /// <para>(0040,A403) Observation Subject Class (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationSubjectClassTrialRetired = ObservationSubjectClassTrial;
        /// <summary>
        /// <para>(0040,A404) Observation Subject Type Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationSubjectTypeCodeSequenceTrialRetired = ObservationSubjectTypeCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A600) Observation Subject Context Flag (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObservationSubjectContextFlagTrialRetired = ObservationSubjectContextFlagTrial;
        /// <summary>
        /// <para>(0040,A601) Observer Context Flag (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ObserverContextFlagTrialRetired = ObserverContextFlagTrial;
        /// <summary>
        /// <para>(0040,A603) Procedure Context Flag (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ProcedureContextFlagTrialRetired = ProcedureContextFlagTrial;
        /// <summary>
        /// <para>(0040,A731) Relationship Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint RelationshipSequenceTrialRetired = RelationshipSequenceTrial;
        /// <summary>
        /// <para>(0040,A732) Relationship Type Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint RelationshipTypeCodeSequenceTrialRetired = RelationshipTypeCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A744) Language Code Sequence (Trial)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint LanguageCodeSequenceTrialRetired = LanguageCodeSequenceTrial;
        /// <summary>
        /// <para>(0040,A992) Uniform Resource Locator (Trial)</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint UniformResourceLocatorTrialRetired = UniformResourceLocatorTrial;
        /// <summary>
        /// <para>(0040,DB06) Template Version</para>
        /// <para> VR: DT VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TemplateVersionRetired = TemplateVersion;
        /// <summary>
        /// <para>(0040,DB07) Template Local Version</para>
        /// <para> VR: DT VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TemplateLocalVersionRetired = TemplateLocalVersion;
        /// <summary>
        /// <para>(0040,DB0B) Template Extension Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TemplateExtensionFlagRetired = TemplateExtensionFlag;
        /// <summary>
        /// <para>(0040,DB0C) Template Extension Organization UID</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TemplateExtensionOrganizationUidRetired = TemplateExtensionOrganizationUid;
        /// <summary>
        /// <para>(0040,DB0D) Template Extension Creator UID</para>
        /// <para> VR: UI VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2001.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2001.")]
        public const uint TemplateExtensionCreatorUidRetired = TemplateExtensionCreatorUid;
        /// <summary>
        /// <para>(0040,E001) HL7 Instance Identifier</para>
        /// <para> VR: ST VM:1</para>
        /// </summary>
        public const uint Hl7InstanceIdentifier = HL7InstanceIdentifier;
        /// <summary>
        /// <para>(0040,E004) HL7 Document Effective Time</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint Hl7DocumentEffectiveTime = HL7DocumentEffectiveTime;
        /// <summary>
        /// <para>(0040,E006) HL7 Document Type Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint Hl7DocumentTypeCodeSequence = HL7DocumentTypeCodeSequence;
        /// <summary>
        /// <para>(0044,0004) Approval Status DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ApprovalStatusDatetime = ApprovalStatusDateTime;
        /// <summary>
        /// <para>(0044,000B) Product Expiration DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint ProductExpirationDatetime = ProductExpirationDateTime;
        /// <summary>
        /// <para>(0044,0010) Substance Administration DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint SubstanceAdministrationDatetime = SubstanceAdministrationDateTime;
        /// <summary>
        /// <para>(0048,0015) Recommended Absent Pixel CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint RecommendedAbsentPixelCielabValue = RecommendedAbsentPixelCieLabValue;
        /// <summary>
        /// <para>(0052,0011) A-line Rate</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint AlineRate = ALineRate;
        /// <summary>
        /// <para>(0052,0012) A-lines Per Frame</para>
        /// <para> VR: US VM:1</para>
        /// </summary>
        public const uint AlinesPerFrame = ALinesPerFrame;
        /// <summary>
        /// <para>(0052,0014) A-line Pixel Spacing</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint AlinePixelSpacing = ALinePixelSpacing;
        /// <summary>
        /// <para>(0052,0026) OCT Z Offset Applied</para>
        /// <para> VR: CS VM:1</para>
        /// </summary>
        public const uint OctZOffsetApplied = OctzOffsetApplied;
        /// <summary>
        /// <para>(0052,0030) OCT Z Offset Correction</para>
        /// <para> VR: SS VM:1</para>
        /// </summary>
        public const uint OctZOffsetCorrection = OctzOffsetCorrection;
        /// <summary>
        /// <para>(0052,0034) First A-line Location</para>
        /// <para> VR: FD VM:1</para>
        /// </summary>
        public const uint FirstAlineLocation = FirstALineLocation;
        /// <summary>
        /// <para>(0052,0038) Number of Padded A-lines</para>
        /// <para> VR: US VM:1</para>
        /// </summary>
        public const uint NumberOfPaddedAlines = NumberOfPaddedALines;
        /// <summary>
        /// <para>(0054,1400) Counts Included</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CountsIncludedRetired = CountsIncluded;
        /// <summary>
        /// <para>(0054,1401) Dead Time Correction Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DeadTimeCorrectionFlagRetired = DeadTimeCorrectionFlag;
        /// <summary>
        /// <para>(0062,000D) Recommended Display CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint RecommendedDisplayCielabValue = RecommendedDisplayCieLabValue;
        /// <summary>
        /// <para>(0068,6226) Effective DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint EffectiveDatetime = EffectiveDateTime;
        /// <summary>
        /// <para>(0068,6270) Information Issue DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint InformationIssueDatetime = InformationIssueDateTime;
        /// <summary>
        /// <para>(0068,62F0) View Orientation Modifier Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint ViewOrientationModifier = ViewOrientationModifierCodeSequence;
        /// <summary>
        /// <para>(0068,6350) Implant Template 3D Model Surface Number</para>
        /// <para> VR: US VM:1-n</para>
        /// </summary>
        public const uint ImplantTemplate3dModelSurfaceNumber = ImplantTemplate3DModelSurfaceNumber;
        /// <summary>
        /// <para>(0070,0050) Displayed Area Top Left Hand Corner (Trial)</para>
        /// <para> VR: US VM:2</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DisplayedAreaTopLeftHandCornerTrialRetired = DisplayedAreaTopLeftHandCornerTrial;
        /// <summary>
        /// <para>(0070,0051) Displayed Area Bottom Right Hand Corner (Trial)</para>
        /// <para> VR: US VM:2</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint DisplayedAreaBottomRightHandCornerTrialRetired = DisplayedAreaBottomRightHandCornerTrial;
        /// <summary>
        /// <para>(0070,0067) Graphic Layer Recommended Display RGB Value</para>
        /// <para> VR: US VM:3</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint GraphicLayerRecommendedDisplayRgbValueRetired = GraphicLayerRecommendedDisplayRgbValue;
        /// <summary>
        /// <para>(0070,0084) Content Creator's Name</para>
        /// <para> VR: PN VM:1</para>
        /// </summary>
        public const uint ContentCreatorsName = ContentCreatorName;
        /// <summary>
        /// <para>(0070,0086) Content Creator's Identification Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint ContentCreatorsIdentificationCodeSequence = ContentCreatorIdentificationCodeSequence;
        /// <summary>
        /// <para>(0070,0241) Text Color CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint TextColorCielabValue = TextColorCieLabValue;
        /// <summary>
        /// <para>(0070,0247) Shadow Color CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint ShadowColorCielabValue = ShadowColorCieLabValue;
        /// <summary>
        /// <para>(0070,0251) Pattern On Color CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint PatternOnColorCielabValue = PatternOnColorCieLabValue;
        /// <summary>
        /// <para>(0070,0252) Pattern Off Color CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint PatternOffColorCielabValue = PatternOffColorCieLabValue;
        /// <summary>
        /// <para>(0070,0401) Graphic Layer Recommended Display CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint GraphicLayerRecommendedDisplayCielabValue = GraphicLayerRecommendedDisplayCieLabValue;
        /// <summary>
        /// <para>(0072,000A) Hanging Protocol Creation Date​Time</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint HangingProtocolCreationDatetime = HangingProtocolCreationDateTime;
        /// <summary>
        /// <para>(0072,0420) Structured Display Background CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint StructuredDisplayBackgroundCielabValue = StructuredDisplayBackgroundCieLabValue;
        /// <summary>
        /// <para>(0072,0421) Empty Image Box CIELab Value</para>
        /// <para> VR: US VM:3</para>
        /// </summary>
        public const uint EmptyImageBoxCielabValue = EmptyImageBoxCieLabValue;
        /// <summary>
        /// <para>(0074,1024) Beam Order Index (Trial)</para>
        /// <para> VR: IS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint BeamOrderIndexTrialRetired = BeamOrderIndexTrial;
        /// <summary>
        /// <para>(0074,1038) Double Exposure Meterset (Trial)</para>
        /// <para> VR: DS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DoubleExposureMetersetTrialRetired = DoubleExposureMetersetTrial;
        /// <summary>
        /// <para>(0074,103A) Double Exposure Field Delta (Trial)</para>
        /// <para> VR: DS VM:4</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint DoubleExposureFieldDeltaTrialRetired = DoubleExposureFieldDeltaTrial;
        /// <summary>
        /// <para>(0074,1220) Related Procedure Step Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint RelatedProcedureStepSequenceRetired = RelatedProcedureStepSequence;
        /// <summary>
        /// <para>(0074,1222) Procedure Step Relationship Type</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ProcedureStepRelationshipTypeRetired = ProcedureStepRelationshipType;
        /// <summary>
        /// <para>(0078,0070) Implant Template Group Member Matching 2D Coordinates Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint ImplantTemplateGroupMemberMatching2dCoordinatesSequence = ImplantTemplateGroupMemberMatching2DCoordinatesSequence;
        /// <summary>
        /// <para>(0088,0904) Topic Title</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TopicTitleRetired = TopicTitle;
        /// <summary>
        /// <para>(0088,0906) Topic Subject</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TopicSubjectRetired = TopicSubject;
        /// <summary>
        /// <para>(0088,0910) Topic Author</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TopicAuthorRetired = TopicAuthor;
        /// <summary>
        /// <para>(0088,0912) Topic Keywords</para>
        /// <para> VR: LO VM:1-32</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint TopicKeywordsRetired = TopicKeywords;
        /// <summary>
        /// <para>(0100,0420) SOP Authorization DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint SopAuthorizationDatetime = SopAuthorizationDateTime;
        /// <summary>
        /// <para>(0400,0105) Digital Signature DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint DigitalSignatureDatetime = DigitalSignatureDateTime;
        /// <summary>
        /// <para>(0400,0562) Attribute Modification DateTime</para>
        /// <para> VR: DT VM:1</para>
        /// </summary>
        public const uint AttributeModificationDatetime = AttributeModificationDateTime;
        /// <summary>
        /// <para>(2000,0062) Color Image Printing Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ColorImagePrintingFlagRetired = ColorImagePrintingFlag;
        /// <summary>
        /// <para>(2000,0063) Collation Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CollationFlagRetired = CollationFlag;
        /// <summary>
        /// <para>(2000,0065) Annotation Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AnnotationFlagRetired = AnnotationFlag;
        /// <summary>
        /// <para>(2000,0067) Image Overlay Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ImageOverlayFlagRetired = ImageOverlayFlag;
        /// <summary>
        /// <para>(2000,0069) Presentation LUT Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PresentationLutFlagRetired = PresentationLutFlag;
        /// <summary>
        /// <para>(2000,006A) Image Box Presentation LUT Flag</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ImageBoxPresentationLutFlagRetired = ImageBoxPresentationLutFlag;
        /// <summary>
        /// <para>(2000,0510) Referenced Stored Print Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint ReferencedStoredPrintSequenceRetired = ReferencedStoredPrintSequence;
        /// <summary>
        /// <para>(2020,0130) Referenced Image Overlay Box Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint ReferencedImageOverlayBoxSequenceRetired = ReferencedImageOverlayBoxSequence;
        /// <summary>
        /// <para>(2020,0140) Referenced VOI LUT Box Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint ReferencedVoiLutBoxSequenceRetired = ReferencedVoiLutBoxSequence;
        /// <summary>
        /// <para>(2040,0010) Referenced Overlay Plane Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedOverlayPlaneSequenceRetired = ReferencedOverlayPlaneSequence;
        /// <summary>
        /// <para>(2040,0011) Referenced Overlay Plane Groups</para>
        /// <para> VR: US VM:1-99</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedOverlayPlaneGroupsRetired = ReferencedOverlayPlaneGroups;
        /// <summary>
        /// <para>(2040,0020) Overlay Pixel Data Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayPixelDataSequenceRetired = OverlayPixelDataSequence;
        /// <summary>
        /// <para>(2040,0060) Overlay Magnification Type</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayMagnificationTypeRetired = OverlayMagnificationType;
        /// <summary>
        /// <para>(2040,0070) Overlay Smoothing Type</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlaySmoothingTypeRetired = OverlaySmoothingType;
        /// <summary>
        /// <para>(2040,0072) Overlay or Image Magnification</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayOrImageMagnificationRetired = OverlayOrImageMagnification;
        /// <summary>
        /// <para>(2040,0074) Magnify to Number of Columns</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint MagnifyToNumberOfColumnsRetired = MagnifyToNumberOfColumns;
        /// <summary>
        /// <para>(2040,0080) Overlay Foreground Density</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayForegroundDensityRetired = OverlayForegroundDensity;
        /// <summary>
        /// <para>(2040,0082) Overlay Background Density</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint OverlayBackgroundDensityRetired = OverlayBackgroundDensity;
        /// <summary>
        /// <para>(2040,0090) Overlay Mode</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint OverlayModeRetired = OverlayMode;
        /// <summary>
        /// <para>(2040,0100) Threshold Density</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1998.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1998.")]
        public const uint ThresholdDensityRetired = ThresholdDensity;
        /// <summary>
        /// <para>(2100,0010) Print Job ID</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint PrintJobIdRetired = PrintJobId;
        /// <summary>
        /// <para>(2100,0140) Destination AE</para>
        /// <para> VR: AE VM:1</para>
        /// </summary>
        public const uint DestinationAeRetired = DestinationAe;
        /// <summary>
        /// <para>(2100,0500) Referenced Print Job Sequence (Pull Stored Print)</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedPrintJobSequencePullStoredPrintRetired = ReferencedPrintJobSequencePullStoredPrint;
        /// <summary>
        /// <para>(2110,0099) Print Queue ID</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PrintQueueIdRetired = PrintQueueId;
        /// <summary>
        /// <para>(2120,0010) Queue Status</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint QueueStatusRetired = QueueStatus;
        /// <summary>
        /// <para>(2120,0050) Print Job Description Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PrintJobDescriptionSequenceRetired = PrintJobDescriptionSequence;
        /// <summary>
        /// <para>(2120,0070) Referenced Print Job Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedPrintJobSequenceRetired = ReferencedPrintJobSequence;
        /// <summary>
        /// <para>(2130,0010) Print Management Capabilities Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PrintManagementCapabilitiesSequenceRetired = PrintManagementCapabilitiesSequence;
        /// <summary>
        /// <para>(2130,0015) Printer Characteristics Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PrinterCharacteristicsSequenceRetired = PrinterCharacteristicsSequence;
        /// <summary>
        /// <para>(2130,0030) Film Box Content Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint FilmBoxContentSequenceRetired = FilmBoxContentSequence;
        /// <summary>
        /// <para>(2130,0040) Image Box Content Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ImageBoxContentSequenceRetired = ImageBoxContentSequence;
        /// <summary>
        /// <para>(2130,0050) Annotation Content Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AnnotationContentSequenceRetired = AnnotationContentSequence;
        /// <summary>
        /// <para>(2130,0060) Image Overlay Box Content Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ImageOverlayBoxContentSequenceRetired = ImageOverlayBoxContentSequence;
        /// <summary>
        /// <para>(2130,0080) Presentation LUT Content Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PresentationLutContentSequenceRetired = PresentationLutContentSequence;
        /// <summary>
        /// <para>(2130,00A0) Proposed Study Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint ProposedStudySequenceRetired = ProposedStudySequence;
        /// <summary>
        /// <para>(2130,00C0) Original Image Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// </summary>
        public const uint OriginalImageSequenceRetired = OriginalImageSequence;
        /// <summary>
        /// <para>(300A,02D4) Control Point 3D Position</para>
        /// <para> VR: DS VM:3</para>
        /// </summary>
        public const uint ControlPoint3dPosition = ControlPoint3DPosition;
        /// <summary>
        /// <para>(4000,0010) Arbitrary</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint ArbitraryRetired = Arbitrary;
        /// <summary>
        /// <para>(4000,4000) Text Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint TextCommentsRetired = TextComments;
        /// <summary>
        /// <para>(4008,0040) Results ID</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ResultsIdRetired = ResultsId;
        /// <summary>
        /// <para>(4008,0042) Results ID Issuer</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ResultsIdIssuerRetired = ResultsIdIssuer;
        /// <summary>
        /// <para>(4008,0050) Referenced Interpretation Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferencedInterpretationSequenceRetired = ReferencedInterpretationSequence;
        /// <summary>
        /// <para>(4008,00FF) Report Production Status (Trial)</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2009.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2009.")]
        public const uint ReportProductionStatusTrialRetired = ReportProductionStatusTrial;
        /// <summary>
        /// <para>(4008,0100) Interpretation Recorded Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationRecordedDateRetired = InterpretationRecordedDate;
        /// <summary>
        /// <para>(4008,0101) Interpretation Recorded Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationRecordedTimeRetired = InterpretationRecordedTime;
        /// <summary>
        /// <para>(4008,0102) Interpretation Recorder</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationRecorderRetired = InterpretationRecorder;
        /// <summary>
        /// <para>(4008,0103) Reference to Recorded Sound</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ReferenceToRecordedSoundRetired = ReferenceToRecordedSound;
        /// <summary>
        /// <para>(4008,0108) Interpretation Transcription Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationTranscriptionDateRetired = InterpretationTranscriptionDate;
        /// <summary>
        /// <para>(4008,0109) Interpretation Transcription Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationTranscriptionTimeRetired = InterpretationTranscriptionTime;
        /// <summary>
        /// <para>(4008,010A) Interpretation Transcriber</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationTranscriberRetired = InterpretationTranscriber;
        /// <summary>
        /// <para>(4008,010B) Interpretation Text</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationTextRetired = InterpretationText;
        /// <summary>
        /// <para>(4008,010C) Interpretation Author</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationAuthorRetired = InterpretationAuthor;
        /// <summary>
        /// <para>(4008,0111) Interpretation Approver Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationApproverSequenceRetired = InterpretationApproverSequence;
        /// <summary>
        /// <para>(4008,0112) Interpretation Approval Date</para>
        /// <para> VR: DA VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationApprovalDateRetired = InterpretationApprovalDate;
        /// <summary>
        /// <para>(4008,0113) Interpretation Approval Time</para>
        /// <para> VR: TM VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationApprovalTimeRetired = InterpretationApprovalTime;
        /// <summary>
        /// <para>(4008,0114) Physician Approving Interpretation</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint PhysicianApprovingInterpretationRetired = PhysicianApprovingInterpretation;
        /// <summary>
        /// <para>(4008,0115) Interpretation Diagnosis Description</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationDiagnosisDescriptionRetired = InterpretationDiagnosisDescription;
        /// <summary>
        /// <para>(4008,0117) Interpretation Diagnosis Code Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationDiagnosisCodeSequenceRetired = InterpretationDiagnosisCodeSequence;
        /// <summary>
        /// <para>(4008,0118) Results Distribution List Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ResultsDistributionListSequenceRetired = ResultsDistributionListSequence;
        /// <summary>
        /// <para>(4008,0119) Distribution Name</para>
        /// <para> VR: PN VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DistributionNameRetired = DistributionName;
        /// <summary>
        /// <para>(4008,011A) Distribution Address</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DistributionAddressRetired = DistributionAddress;
        /// <summary>
        /// <para>(4008,0200) Interpretation ID</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationIdRetired = InterpretationId;
        /// <summary>
        /// <para>(4008,0202) Interpretation ID Issuer</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationIdIssuerRetired = InterpretationIdIssuer;
        /// <summary>
        /// <para>(4008,0210) Interpretation Type ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationTypeIdRetired = InterpretationTypeId;
        /// <summary>
        /// <para>(4008,0212) Interpretation Status ID</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint InterpretationStatusIdRetired = InterpretationStatusId;
        /// <summary>
        /// <para>(4008,0300) Impressions</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ImpressionsRetired = Impressions;
        /// <summary>
        /// <para>(4008,4000) Results Comments</para>
        /// <para> VR: ST VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint ResultsCommentsRetired = ResultsComments;
        /// <summary>
        /// <para>(50xx,0005) Curve Dimensions</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveDimensionsRetired = CurveDimensions;
        /// <summary>
        /// <para>(50xx,0010) Number of Points</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint NumberOfPointsRetired = NumberOfPoints;
        /// <summary>
        /// <para>(50xx,0020) Type of Data</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TypeOfDataRetired = TypeOfData;
        /// <summary>
        /// <para>(50xx,0022) Curve Description</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveDescriptionRetired = CurveDescription;
        /// <summary>
        /// <para>(50xx,0030) Axis Units</para>
        /// <para> VR: SH VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AxisUnitsRetired = AxisUnits;
        /// <summary>
        /// <para>(50xx,0040) Axis Labels</para>
        /// <para> VR: SH VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AxisLabelsRetired = AxisLabels;
        /// <summary>
        /// <para>(50xx,0103) Data Value Representation</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint DataValueRepresentationRetired = DataValueRepresentation;
        /// <summary>
        /// <para>(50xx,0104) Minimum Coordinate Value</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint MinimumCoordinateValueRetired = MinimumCoordinateValue;
        /// <summary>
        /// <para>(50xx,0105) Maximum Coordinate Value</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint MaximumCoordinateValueRetired = MaximumCoordinateValue;
        /// <summary>
        /// <para>(50xx,0106) Curve Range</para>
        /// <para> VR: SH VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveRangeRetired = CurveRange;
        /// <summary>
        /// <para>(50xx,0110) Curve Data Descriptor</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveDataDescriptorRetired = CurveDataDescriptor;
        /// <summary>
        /// <para>(50xx,0112) Coordinate Start Value</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CoordinateStartValueRetired = CoordinateStartValue;
        /// <summary>
        /// <para>(50xx,0114) Coordinate Step Value</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CoordinateStepValueRetired = CoordinateStepValue;
        /// <summary>
        /// <para>(50xx,1001) Curve Activation Layer</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveActivationLayerRetired = CurveActivationLayer;
        /// <summary>
        /// <para>(50xx,2000) Audio Type</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AudioTypeRetired = AudioType;
        /// <summary>
        /// <para>(50xx,2002) Audio Sample Format</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AudioSampleFormatRetired = AudioSampleFormat;
        /// <summary>
        /// <para>(50xx,2004) Number of Channels</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint NumberOfChannelsRetired = NumberOfChannels;
        /// <summary>
        /// <para>(50xx,2006) Number of Samples</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint NumberOfSamplesRetired = NumberOfSamples;
        /// <summary>
        /// <para>(50xx,2008) Sample Rate</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint SampleRateRetired = SampleRate;
        /// <summary>
        /// <para>(50xx,200A) Total Time</para>
        /// <para> VR: UL VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint TotalTimeRetired = TotalTime;
        /// <summary>
        /// <para>(50xx,200C) Audio Sample Data</para>
        /// <para> VR: OB or OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AudioSampleDataRetired = AudioSampleData;
        /// <summary>
        /// <para>(50xx,200E) Audio Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint AudioCommentsRetired = AudioComments;
        /// <summary>
        /// <para>(50xx,2500) Curve Label</para>
        /// <para> VR: LO VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveLabelRetired = CurveLabel;
        /// <summary>
        /// <para>(50xx,2600) Curve Referenced Overlay Sequence</para>
        /// <para> VR: SQ VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveReferencedOverlaySequenceRetired = CurveReferencedOverlaySequence;
        /// <summary>
        /// <para>(50xx,2610) Curve Referenced Overlay Group</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveReferencedOverlayGroupRetired = CurveReferencedOverlayGroup;
        /// <summary>
        /// <para>(50xx,3000) Curve Data</para>
        /// <para> VR: OB or OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2004.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2004.")]
        public const uint CurveDataRetired = CurveData;
        /// <summary>
        /// <para>(60xx,0012) Overlay Planes</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayPlanesRetired = OverlayPlanes;
        /// <summary>
        /// <para>(60xx,0052) Overlay Plane Origin</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayPlaneOriginRetired = OverlayPlaneOrigin;
        /// <summary>
        /// <para>(60xx,0060) Overlay Compression Code</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OverlayCompressionCodeRetired = OverlayCompressionCode;
        /// <summary>
        /// <para>(60xx,0061) Overlay Compression Originator</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCompressionOriginatorRetired = OverlayCompressionOriginator;
        /// <summary>
        /// <para>(60xx,0062) Overlay Compression Label</para>
        /// <para> VR: SH VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCompressionLabelRetired = OverlayCompressionLabel;
        /// <summary>
        /// <para>(60xx,0063) Overlay Compression Description</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCompressionDescriptionRetired = OverlayCompressionDescription;
        /// <summary>
        /// <para>(60xx,0066) Overlay Compression Step Pointers</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCompressionStepPointersRetired = OverlayCompressionStepPointers;
        /// <summary>
        /// <para>(60xx,0068) Overlay Repeat Interval</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayRepeatIntervalRetired = OverlayRepeatInterval;
        /// <summary>
        /// <para>(60xx,0069) Overlay Bits Grouped</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayBitsGroupedRetired = OverlayBitsGrouped;
        /// <summary>
        /// <para>(60xx,0110) Overlay Format</para>
        /// <para> VR: CS VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OverlayFormatRetired = OverlayFormat;
        /// <summary>
        /// <para>(60xx,0200) Overlay Location</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OverlayLocationRetired = OverlayLocation;
        /// <summary>
        /// <para>(60xx,0800) Overlay Code Label</para>
        /// <para> VR: CS VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCodeLabelRetired = OverlayCodeLabel;
        /// <summary>
        /// <para>(60xx,0802) Overlay Number of Tables</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayNumberOfTablesRetired = OverlayNumberOfTables;
        /// <summary>
        /// <para>(60xx,0803) Overlay Code Table Location</para>
        /// <para> VR: AT VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayCodeTableLocationRetired = OverlayCodeTableLocation;
        /// <summary>
        /// <para>(60xx,0804) Overlay Bits For Code Word</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint OverlayBitsForCodeWordRetired = OverlayBitsForCodeWord;
        /// <summary>
        /// <para>(60xx,1100) Overlay Descriptor - Gray</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlayDescriptorGrayRetired = OverlayDescriptorGray;
        /// <summary>
        /// <para>(60xx,1101) Overlay Descriptor - Red</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlayDescriptorRedRetired = OverlayDescriptorRed;
        /// <summary>
        /// <para>(60xx,1102) Overlay Descriptor - Green</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlayDescriptorGreenRetired = OverlayDescriptorGreen;
        /// <summary>
        /// <para>(60xx,1103) Overlay Descriptor - Blue</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlayDescriptorBlueRetired = OverlayDescriptorBlue;
        /// <summary>
        /// <para>(60xx,1200) Overlays - Gray</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlaysGrayRetired = OverlaysGray;
        /// <summary>
        /// <para>(60xx,1201) Overlays - Red</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlaysRedRetired = OverlaysRed;
        /// <summary>
        /// <para>(60xx,1202) Overlays - Green</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlaysGreenRetired = OverlaysGreen;
        /// <summary>
        /// <para>(60xx,1203) Overlays - Blue</para>
        /// <para> VR: US VM:1-n</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 1996.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 1996.")]
        public const uint OverlaysBlueRetired = OverlaysBlue;
        /// <summary>
        /// <para>(60xx,4000) Overlay Comments</para>
        /// <para> VR: LT VM:1</para>
        /// <para>This tag has been retired.</para>
        /// </summary>
        [Obsolete("This tag has been retired.")]
        public const uint OverlayCommentsRetired = OverlayComments;
        /// <summary>
        /// <para>(7Fxx,0010) Variable Pixel Data</para>
        /// <para> VR: OB or OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VariablePixelDataRetired = VariablePixelData;
        /// <summary>
        /// <para>(7Fxx,0011) Variable Next Data Group</para>
        /// <para> VR: US VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VariableNextDataGroupRetired = VariableNextDataGroup;
        /// <summary>
        /// <para>(7Fxx,0020) Variable Coefficients SDVN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VariableCoefficientsSdvnRetired = VariableCoefficientsSdvn;
        /// <summary>
        /// <para>(7Fxx,0030) Variable Coefficients SDHN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VariableCoefficientsSdhnRetired = VariableCoefficientsSdhn;
        /// <summary>
        /// <para>(7Fxx,0040) Variable Coefficients SDDN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint VariableCoefficientsSddnRetired = VariableCoefficientsSddn;
        /// <summary>
        /// <para>(7FE0,0020) Coefficients SDVN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CoefficientsSdvnRetired = CoefficientsSdvn;
        /// <summary>
        /// <para>(7FE0,0030) Coefficients SDHN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CoefficientsSdhnRetired = CoefficientsSdhn;
        /// <summary>
        /// <para>(7FE0,0040) Coefficients SDDN</para>
        /// <para> VR: OW VM:1</para>
        /// <para>This tag has been retired. Refer to DICOM PS3 2007.</para>
        /// </summary>
        [Obsolete("This tag has been retired. Refer to DICOM PS3 2007.")]
        public const uint CoefficientsSddnRetired = CoefficientsSddn;
    }
}
