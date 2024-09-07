using System;
using System.Collections.Generic;

// This file is auto-generated
// ReSharper disable InconsistentNaming

namespace ClearCanvas.Dicom
{
    partial class DicomUids
    {
        /// <summary>
        /// Enumerates all defined DICOM UIDs.
        /// </summary>
        public static IEnumerable<DicomUid> EnumerateDicomUids()
        {
            #pragma warning disable CS0618 // Type or member is obsolete
            yield return Verification;
            yield return ImplicitVRLittleEndian;
            yield return ExplicitVRLittleEndian;
            yield return EncapsulatedUncompressedExplicitVRLittleEndian;
            yield return DeflatedExplicitVRLittleEndian;
            yield return ExplicitVRBigEndian;
            yield return JPEGBaseline8Bit;
            yield return JPEGExtended12Bit;
            yield return JPEGExtended35;
            yield return JPEGSpectralSelectionNonHierarchical68;
            yield return JPEGSpectralSelectionNonHierarchical79;
            yield return JPEGFullProgressionNonHierarchical1012;
            yield return JPEGFullProgressionNonHierarchical1113;
            yield return JPEGLossless;
            yield return JPEGLosslessNonHierarchical15;
            yield return JPEGExtendedHierarchical1618;
            yield return JPEGExtendedHierarchical1719;
            yield return JPEGSpectralSelectionHierarchical2022;
            yield return JPEGSpectralSelectionHierarchical2123;
            yield return JPEGFullProgressionHierarchical2426;
            yield return JPEGFullProgressionHierarchical2527;
            yield return JPEGLosslessHierarchical28;
            yield return JPEGLosslessHierarchical29;
            yield return JPEGLosslessSV1;
            yield return JPEGLSLossless;
            yield return JPEGLSNearLossless;
            yield return JPEG2000Lossless;
            yield return JPEG2000;
            yield return JPEG2000MCLossless;
            yield return JPEG2000MC;
            yield return JPIPReferenced;
            yield return JPIPReferencedDeflate;
            yield return MPEG2MPML;
            yield return MPEG2MPMLF;
            yield return MPEG2MPHL;
            yield return MPEG2MPHLF;
            yield return MPEG4HP41;
            yield return MPEG4HP41F;
            yield return MPEG4HP41BD;
            yield return MPEG4HP41BDF;
            yield return MPEG4HP422D;
            yield return MPEG4HP422DF;
            yield return MPEG4HP423D;
            yield return MPEG4HP423DF;
            yield return MPEG4HP42STEREO;
            yield return MPEG4HP42STEREOF;
            yield return HEVCMP51;
            yield return HEVCM10P51;
            yield return HTJ2KLossless;
            yield return HTJ2KLosslessRPCL;
            yield return HTJ2K;
            yield return JPIPHTJ2KReferenced;
            yield return JPIPHTJ2KReferencedDeflate;
            yield return RLELossless;
            yield return RFC2557MIMEEncapsulation;
            yield return XMLEncoding;
            yield return SMPTEST211020UncompressedProgressiveActiveVideo;
            yield return SMPTEST211020UncompressedInterlacedActiveVideo;
            yield return SMPTEST211030PCMDigitalAudio;
            yield return MediaStorageDirectoryStorage;
            yield return HotIronPalette;
            yield return PETPalette;
            yield return HotMetalBluePalette;
            yield return PET20StepPalette;
            yield return SpringPalette;
            yield return SummerPalette;
            yield return FallPalette;
            yield return WinterPalette;
            yield return BasicStudyContentNotification;
            yield return Papyrus3ImplicitVRLittleEndian;
            yield return StorageCommitmentPushModel;
            yield return StorageCommitmentPushModelInstance;
            yield return StorageCommitmentPullModel;
            yield return StorageCommitmentPullModelInstance;
            yield return ProceduralEventLogging;
            yield return ProceduralEventLoggingInstance;
            yield return SubstanceAdministrationLogging;
            yield return SubstanceAdministrationLoggingInstance;
            yield return DCMUID;
            yield return DCM;
            yield return MA;
            yield return UBERON;
            yield return ITIS_TSN;
            yield return MGI;
            yield return PUBCHEM_CID;
            yield return DC;
            yield return NYUMCCG;
            yield return MAYONRISBSASRG;
            yield return IBSI;
            yield return RO;
            yield return RADELEMENT;
            yield return I11;
            yield return UNS;
            yield return RRID;
            yield return DICOMApplicationContext;
            yield return DetachedPatientManagement;
            yield return DetachedPatientManagementMeta;
            yield return DetachedVisitManagement;
            yield return DetachedStudyManagement;
            yield return StudyComponentManagement;
            yield return ModalityPerformedProcedureStep;
            yield return ModalityPerformedProcedureStepRetrieve;
            yield return ModalityPerformedProcedureStepNotification;
            yield return DetachedResultsManagement;
            yield return DetachedResultsManagementMeta;
            yield return DetachedStudyManagementMeta;
            yield return DetachedInterpretationManagement;
            yield return Storage;
            yield return BasicFilmSession;
            yield return BasicFilmBox;
            yield return BasicGrayscaleImageBox;
            yield return BasicColorImageBox;
            yield return ReferencedImageBox;
            yield return BasicGrayscalePrintManagementMeta;
            yield return ReferencedGrayscalePrintManagementMeta;
            yield return PrintJob;
            yield return BasicAnnotationBox;
            yield return Printer;
            yield return PrinterConfigurationRetrieval;
            yield return PrinterInstance;
            yield return PrinterConfigurationRetrievalInstance;
            yield return BasicColorPrintManagementMeta;
            yield return ReferencedColorPrintManagementMeta;
            yield return VOILUTBox;
            yield return PresentationLUT;
            yield return ImageOverlayBox;
            yield return BasicPrintImageOverlayBox;
            yield return PrintQueueInstance;
            yield return PrintQueueManagement;
            yield return StoredPrintStorage;
            yield return HardcopyGrayscaleImageStorage;
            yield return HardcopyColorImageStorage;
            yield return PullPrintRequest;
            yield return PullStoredPrintManagementMeta;
            yield return MediaCreationManagement;
            yield return DisplaySystem;
            yield return DisplaySystemInstance;
            yield return ComputedRadiographyImageStorage;
            yield return DigitalXRayImageStorageForPresentation;
            yield return DigitalXRayImageStorageForProcessing;
            yield return DigitalMammographyXRayImageStorageForPresentation;
            yield return DigitalMammographyXRayImageStorageForProcessing;
            yield return DigitalIntraOralXRayImageStorageForPresentation;
            yield return DigitalIntraOralXRayImageStorageForProcessing;
            yield return CTImageStorage;
            yield return EnhancedCTImageStorage;
            yield return LegacyConvertedEnhancedCTImageStorage;
            yield return UltrasoundMultiFrameImageStorageRetired;
            yield return UltrasoundMultiFrameImageStorage;
            yield return MRImageStorage;
            yield return EnhancedMRImageStorage;
            yield return MRSpectroscopyStorage;
            yield return EnhancedMRColorImageStorage;
            yield return LegacyConvertedEnhancedMRImageStorage;
            yield return NuclearMedicineImageStorageRetired;
            yield return UltrasoundImageStorageRetired;
            yield return UltrasoundImageStorage;
            yield return EnhancedUSVolumeStorage;
            yield return PhotoacousticImageStorage;
            yield return SecondaryCaptureImageStorage;
            yield return MultiFrameSingleBitSecondaryCaptureImageStorage;
            yield return MultiFrameGrayscaleByteSecondaryCaptureImageStorage;
            yield return MultiFrameGrayscaleWordSecondaryCaptureImageStorage;
            yield return MultiFrameTrueColorSecondaryCaptureImageStorage;
            yield return StandaloneOverlayStorage;
            yield return StandaloneCurveStorage;
            yield return WaveformStorageTrial;
            yield return TwelveLeadECGWaveformStorage;
            yield return GeneralECGWaveformStorage;
            yield return AmbulatoryECGWaveformStorage;
            yield return General32bitECGWaveformStorage;
            yield return HemodynamicWaveformStorage;
            yield return CardiacElectrophysiologyWaveformStorage;
            yield return BasicVoiceAudioWaveformStorage;
            yield return GeneralAudioWaveformStorage;
            yield return ArterialPulseWaveformStorage;
            yield return RespiratoryWaveformStorage;
            yield return MultichannelRespiratoryWaveformStorage;
            yield return RoutineScalpElectroencephalogramWaveformStorage;
            yield return ElectromyogramWaveformStorage;
            yield return ElectrooculogramWaveformStorage;
            yield return SleepElectroencephalogramWaveformStorage;
            yield return BodyPositionWaveformStorage;
            yield return StandaloneModalityLUTStorage;
            yield return StandaloneVOILUTStorage;
            yield return GrayscaleSoftcopyPresentationStateStorage;
            yield return ColorSoftcopyPresentationStateStorage;
            yield return PseudoColorSoftcopyPresentationStateStorage;
            yield return BlendingSoftcopyPresentationStateStorage;
            yield return XAXRFGrayscaleSoftcopyPresentationStateStorage;
            yield return GrayscalePlanarMPRVolumetricPresentationStateStorage;
            yield return CompositingPlanarMPRVolumetricPresentationStateStorage;
            yield return AdvancedBlendingPresentationStateStorage;
            yield return VolumeRenderingVolumetricPresentationStateStorage;
            yield return SegmentedVolumeRenderingVolumetricPresentationStateStorage;
            yield return MultipleVolumeRenderingVolumetricPresentationStateStorage;
            yield return VariableModalityLUTSoftcopyPresentationStateStorage;
            yield return XRayAngiographicImageStorage;
            yield return EnhancedXAImageStorage;
            yield return XRayRadiofluoroscopicImageStorage;
            yield return EnhancedXRFImageStorage;
            yield return XRayAngiographicBiPlaneImageStorage;
            yield return XRay3DAngiographicImageStorage;
            yield return XRay3DCraniofacialImageStorage;
            yield return BreastTomosynthesisImageStorage;
            yield return BreastProjectionXRayImageStorageForPresentation;
            yield return BreastProjectionXRayImageStorageForProcessing;
            yield return IntravascularOpticalCoherenceTomographyImageStorageForPresentation;
            yield return IntravascularOpticalCoherenceTomographyImageStorageForProcessing;
            yield return NuclearMedicineImageStorage;
            yield return ParametricMapStorage;
            yield return RawDataStorage;
            yield return SpatialRegistrationStorage;
            yield return SpatialFiducialsStorage;
            yield return DeformableSpatialRegistrationStorage;
            yield return SegmentationStorage;
            yield return SurfaceSegmentationStorage;
            yield return TractographyResultsStorage;
            yield return RealWorldValueMappingStorage;
            yield return SurfaceScanMeshStorage;
            yield return SurfaceScanPointCloudStorage;
            yield return VLImageStorageTrial;
            yield return VLMultiFrameImageStorageTrial;
            yield return VLEndoscopicImageStorage;
            yield return VideoEndoscopicImageStorage;
            yield return VLMicroscopicImageStorage;
            yield return VideoMicroscopicImageStorage;
            yield return VLSlideCoordinatesMicroscopicImageStorage;
            yield return VLPhotographicImageStorage;
            yield return VideoPhotographicImageStorage;
            yield return OphthalmicPhotography8BitImageStorage;
            yield return OphthalmicPhotography16BitImageStorage;
            yield return StereometricRelationshipStorage;
            yield return OphthalmicTomographyImageStorage;
            yield return WideFieldOphthalmicPhotographyStereographicProjectionImageStorage;
            yield return WideFieldOphthalmicPhotography3DCoordinatesImageStorage;
            yield return OphthalmicOpticalCoherenceTomographyEnFaceImageStorage;
            yield return OphthalmicOpticalCoherenceTomographyBscanVolumeAnalysisStorage;
            yield return VLWholeSlideMicroscopyImageStorage;
            yield return DermoscopicPhotographyImageStorage;
            yield return ConfocalMicroscopyImageStorage;
            yield return ConfocalMicroscopyTiledPyramidalImageStorage;
            yield return LensometryMeasurementsStorage;
            yield return AutorefractionMeasurementsStorage;
            yield return KeratometryMeasurementsStorage;
            yield return SubjectiveRefractionMeasurementsStorage;
            yield return VisualAcuityMeasurementsStorage;
            yield return SpectaclePrescriptionReportStorage;
            yield return OphthalmicAxialMeasurementsStorage;
            yield return IntraocularLensCalculationsStorage;
            yield return MacularGridThicknessAndVolumeReportStorage;
            yield return OphthalmicVisualFieldStaticPerimetryMeasurementsStorage;
            yield return OphthalmicThicknessMapStorage;
            yield return CornealTopographyMapStorage;
            yield return TextSRStorageTrial;
            yield return AudioSRStorageTrial;
            yield return DetailSRStorageTrial;
            yield return ComprehensiveSRStorageTrial;
            yield return BasicTextSRStorage;
            yield return EnhancedSRStorage;
            yield return ComprehensiveSRStorage;
            yield return Comprehensive3DSRStorage;
            yield return ExtensibleSRStorage;
            yield return ProcedureLogStorage;
            yield return MammographyCADSRStorage;
            yield return KeyObjectSelectionDocumentStorage;
            yield return ChestCADSRStorage;
            yield return XRayRadiationDoseSRStorage;
            yield return RadiopharmaceuticalRadiationDoseSRStorage;
            yield return ColonCADSRStorage;
            yield return ImplantationPlanSRStorage;
            yield return AcquisitionContextSRStorage;
            yield return SimplifiedAdultEchoSRStorage;
            yield return PatientRadiationDoseSRStorage;
            yield return PlannedImagingAgentAdministrationSRStorage;
            yield return PerformedImagingAgentAdministrationSRStorage;
            yield return EnhancedXRayRadiationDoseSRStorage;
            yield return WaveformAnnotationSRStorage;
            yield return ContentAssessmentResultsStorage;
            yield return MicroscopyBulkSimpleAnnotationsStorage;
            yield return EncapsulatedPDFStorage;
            yield return EncapsulatedCDAStorage;
            yield return EncapsulatedSTLStorage;
            yield return EncapsulatedOBJStorage;
            yield return EncapsulatedMTLStorage;
            yield return PositronEmissionTomographyImageStorage;
            yield return LegacyConvertedEnhancedPETImageStorage;
            yield return StandalonePETCurveStorage;
            yield return EnhancedPETImageStorage;
            yield return BasicStructuredDisplayStorage;
            yield return CTDefinedProcedureProtocolStorage;
            yield return CTPerformedProcedureProtocolStorage;
            yield return ProtocolApprovalStorage;
            yield return ProtocolApprovalInformationModelFind;
            yield return ProtocolApprovalInformationModelMove;
            yield return ProtocolApprovalInformationModelGet;
            yield return XADefinedProcedureProtocolStorage;
            yield return XAPerformedProcedureProtocolStorage;
            yield return InventoryStorage;
            yield return InventoryFind;
            yield return InventoryMove;
            yield return InventoryGet;
            yield return InventoryCreation;
            yield return RepositoryQuery;
            yield return StorageManagementInstance;
            yield return RTImageStorage;
            yield return RTDoseStorage;
            yield return RTStructureSetStorage;
            yield return RTBeamsTreatmentRecordStorage;
            yield return RTPlanStorage;
            yield return RTBrachyTreatmentRecordStorage;
            yield return RTTreatmentSummaryRecordStorage;
            yield return RTIonPlanStorage;
            yield return RTIonBeamsTreatmentRecordStorage;
            yield return RTPhysicianIntentStorage;
            yield return RTSegmentAnnotationStorage;
            yield return RTRadiationSetStorage;
            yield return CArmPhotonElectronRadiationStorage;
            yield return TomotherapeuticRadiationStorage;
            yield return RoboticArmRadiationStorage;
            yield return RTRadiationRecordSetStorage;
            yield return RTRadiationSalvageRecordStorage;
            yield return TomotherapeuticRadiationRecordStorage;
            yield return CArmPhotonElectronRadiationRecordStorage;
            yield return RoboticRadiationRecordStorage;
            yield return RTRadiationSetDeliveryInstructionStorage;
            yield return RTTreatmentPreparationStorage;
            yield return EnhancedRTImageStorage;
            yield return EnhancedContinuousRTImageStorage;
            yield return RTPatientPositionAcquisitionInstructionStorage;
            yield return DICOSCTImageStorage;
            yield return DICOSDigitalXRayImageStorageForPresentation;
            yield return DICOSDigitalXRayImageStorageForProcessing;
            yield return DICOSThreatDetectionReportStorage;
            yield return DICOS2DAITStorage;
            yield return DICOS3DAITStorage;
            yield return DICOSQuadrupoleResonanceStorage;
            yield return EddyCurrentImageStorage;
            yield return EddyCurrentMultiFrameImageStorage;
            yield return PatientRootQueryRetrieveInformationModelFind;
            yield return PatientRootQueryRetrieveInformationModelMove;
            yield return PatientRootQueryRetrieveInformationModelGet;
            yield return StudyRootQueryRetrieveInformationModelFind;
            yield return StudyRootQueryRetrieveInformationModelMove;
            yield return StudyRootQueryRetrieveInformationModelGet;
            yield return PatientStudyOnlyQueryRetrieveInformationModelFind;
            yield return PatientStudyOnlyQueryRetrieveInformationModelMove;
            yield return PatientStudyOnlyQueryRetrieveInformationModelGet;
            yield return CompositeInstanceRootRetrieveMove;
            yield return CompositeInstanceRootRetrieveGet;
            yield return CompositeInstanceRetrieveWithoutBulkDataGet;
            yield return DefinedProcedureProtocolInformationModelFind;
            yield return DefinedProcedureProtocolInformationModelMove;
            yield return DefinedProcedureProtocolInformationModelGet;
            yield return ModalityWorklistInformationModelFind;
            yield return GeneralPurposeWorklistManagementMeta;
            yield return GeneralPurposeWorklistInformationModelFind;
            yield return GeneralPurposeScheduledProcedureStep;
            yield return GeneralPurposePerformedProcedureStep;
            yield return InstanceAvailabilityNotification;
            yield return RTBeamsDeliveryInstructionStorageTrial;
            yield return RTConventionalMachineVerificationTrial;
            yield return RTIonMachineVerificationTrial;
            yield return UnifiedWorklistAndProcedureStepTrial;
            yield return UnifiedProcedureStepPushTrial;
            yield return UnifiedProcedureStepWatchTrial;
            yield return UnifiedProcedureStepPullTrial;
            yield return UnifiedProcedureStepEventTrial;
            yield return UPSGlobalSubscriptionInstance;
            yield return UPSFilteredGlobalSubscriptionInstance;
            yield return UnifiedWorklistAndProcedureStep;
            yield return UnifiedProcedureStepPush;
            yield return UnifiedProcedureStepWatch;
            yield return UnifiedProcedureStepPull;
            yield return UnifiedProcedureStepEvent;
            yield return UnifiedProcedureStepQuery;
            yield return RTBeamsDeliveryInstructionStorage;
            yield return RTConventionalMachineVerification;
            yield return RTIonMachineVerification;
            yield return RTBrachyApplicationSetupDeliveryInstructionStorage;
            yield return GeneralRelevantPatientInformationQuery;
            yield return BreastImagingRelevantPatientInformationQuery;
            yield return CardiacRelevantPatientInformationQuery;
            yield return HangingProtocolStorage;
            yield return HangingProtocolInformationModelFind;
            yield return HangingProtocolInformationModelMove;
            yield return HangingProtocolInformationModelGet;
            yield return ColorPaletteStorage;
            yield return ColorPaletteQueryRetrieveInformationModelFind;
            yield return ColorPaletteQueryRetrieveInformationModelMove;
            yield return ColorPaletteQueryRetrieveInformationModelGet;
            yield return ProductCharacteristicsQuery;
            yield return SubstanceApprovalQuery;
            yield return GenericImplantTemplateStorage;
            yield return GenericImplantTemplateInformationModelFind;
            yield return GenericImplantTemplateInformationModelMove;
            yield return GenericImplantTemplateInformationModelGet;
            yield return ImplantAssemblyTemplateStorage;
            yield return ImplantAssemblyTemplateInformationModelFind;
            yield return ImplantAssemblyTemplateInformationModelMove;
            yield return ImplantAssemblyTemplateInformationModelGet;
            yield return ImplantTemplateGroupStorage;
            yield return ImplantTemplateGroupInformationModelFind;
            yield return ImplantTemplateGroupInformationModelMove;
            yield return ImplantTemplateGroupInformationModelGet;
            yield return NativeDICOMModel;
            yield return AbstractMultiDimensionalImageModel;
            yield return DICOMContentMappingResource;
            yield return VideoEndoscopicImageRealTimeCommunication;
            yield return VideoPhotographicImageRealTimeCommunication;
            yield return AudioWaveformRealTimeCommunication;
            yield return RenditionSelectionDocumentRealTimeCommunication;
            yield return dicomDeviceName;
            yield return dicomDescription;
            yield return dicomManufacturer;
            yield return dicomManufacturerModelName;
            yield return dicomSoftwareVersion;
            yield return dicomVendorData;
            yield return dicomAETitle;
            yield return dicomNetworkConnectionReference;
            yield return dicomApplicationCluster;
            yield return dicomAssociationInitiator;
            yield return dicomAssociationAcceptor;
            yield return dicomHostname;
            yield return dicomPort;
            yield return dicomSOPClass;
            yield return dicomTransferRole;
            yield return dicomTransferSyntax;
            yield return dicomPrimaryDeviceType;
            yield return dicomRelatedDeviceReference;
            yield return dicomPreferredCalledAETitle;
            yield return dicomTLSCyphersuite;
            yield return dicomAuthorizedNodeCertificateReference;
            yield return dicomThisNodeCertificateReference;
            yield return dicomInstalled;
            yield return dicomStationName;
            yield return dicomDeviceSerialNumber;
            yield return dicomInstitutionName;
            yield return dicomInstitutionAddress;
            yield return dicomInstitutionDepartmentName;
            yield return dicomIssuerOfPatientID;
            yield return dicomPreferredCallingAETitle;
            yield return dicomSupportedCharacterSet;
            yield return dicomConfigurationRoot;
            yield return dicomDevicesRoot;
            yield return dicomUniqueAETitlesRegistryRoot;
            yield return dicomDevice;
            yield return dicomNetworkAE;
            yield return dicomNetworkConnection;
            yield return dicomUniqueAETitle;
            yield return dicomTransferCapability;
            yield return UTC;
            #pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// <para>SOP Class: Verification SOP Class</para>
        /// <para>1.2.840.10008.1.1</para>
        /// </summary>
        public static readonly DicomUid Verification = new DicomUid("1.2.840.10008.1.1", "Verification SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Transfer Syntax: Implicit VR Little Endian: Default Transfer Syntax for DICOM</para>
        /// <para>1.2.840.10008.1.2</para>
        /// </summary>
        public static readonly DicomUid ImplicitVRLittleEndian = new DicomUid("1.2.840.10008.1.2", "Implicit VR Little Endian: Default Transfer Syntax for DICOM", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Explicit VR Little Endian</para>
        /// <para>1.2.840.10008.1.2.1</para>
        /// </summary>
        public static readonly DicomUid ExplicitVRLittleEndian = new DicomUid("1.2.840.10008.1.2.1", "Explicit VR Little Endian", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Encapsulated Uncompressed Explicit VR Little Endian</para>
        /// <para>1.2.840.10008.1.2.1.98</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedUncompressedExplicitVRLittleEndian = new DicomUid("1.2.840.10008.1.2.1.98", "Encapsulated Uncompressed Explicit VR Little Endian", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Deflated Explicit VR Little Endian</para>
        /// <para>1.2.840.10008.1.2.1.99</para>
        /// </summary>
        public static readonly DicomUid DeflatedExplicitVRLittleEndian = new DicomUid("1.2.840.10008.1.2.1.99", "Deflated Explicit VR Little Endian", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Explicit VR Big Endian</para>
        /// <para>1.2.840.10008.1.2.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2011).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2011).")]
        public static readonly DicomUid ExplicitVRBigEndian = new DicomUid("1.2.840.10008.1.2.2", "Explicit VR Big Endian", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Baseline (Process 1): Default Transfer Syntax for Lossy JPEG 8 Bit Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.50</para>
        /// </summary>
        public static readonly DicomUid JPEGBaseline8Bit = new DicomUid("1.2.840.10008.1.2.4.50", "JPEG Baseline (Process 1): Default Transfer Syntax for Lossy JPEG 8 Bit Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Extended (Process 2 & 4): Default Transfer Syntax for Lossy JPEG 12 Bit Image Compression (Process 4 only)</para>
        /// <para>1.2.840.10008.1.2.4.51</para>
        /// </summary>
        public static readonly DicomUid JPEGExtended12Bit = new DicomUid("1.2.840.10008.1.2.4.51", "JPEG Extended (Process 2 & 4): Default Transfer Syntax for Lossy JPEG 12 Bit Image Compression (Process 4 only)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Extended (Process 3 & 5)</para>
        /// <para>1.2.840.10008.1.2.4.52</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGExtended35 = new DicomUid("1.2.840.10008.1.2.4.52", "JPEG Extended (Process 3 & 5)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Spectral Selection, Non-Hierarchical (Process 6 & 8)</para>
        /// <para>1.2.840.10008.1.2.4.53</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGSpectralSelectionNonHierarchical68 = new DicomUid("1.2.840.10008.1.2.4.53", "JPEG Spectral Selection, Non-Hierarchical (Process 6 & 8)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Spectral Selection, Non-Hierarchical (Process 7 & 9)</para>
        /// <para>1.2.840.10008.1.2.4.54</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGSpectralSelectionNonHierarchical79 = new DicomUid("1.2.840.10008.1.2.4.54", "JPEG Spectral Selection, Non-Hierarchical (Process 7 & 9)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Full Progression, Non-Hierarchical (Process 10 & 12)</para>
        /// <para>1.2.840.10008.1.2.4.55</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGFullProgressionNonHierarchical1012 = new DicomUid("1.2.840.10008.1.2.4.55", "JPEG Full Progression, Non-Hierarchical (Process 10 & 12)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Full Progression, Non-Hierarchical (Process 11 & 13)</para>
        /// <para>1.2.840.10008.1.2.4.56</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGFullProgressionNonHierarchical1113 = new DicomUid("1.2.840.10008.1.2.4.56", "JPEG Full Progression, Non-Hierarchical (Process 11 & 13)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Lossless, Non-Hierarchical (Process 14)</para>
        /// <para>1.2.840.10008.1.2.4.57</para>
        /// </summary>
        public static readonly DicomUid JPEGLossless = new DicomUid("1.2.840.10008.1.2.4.57", "JPEG Lossless, Non-Hierarchical (Process 14)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Lossless, Non-Hierarchical (Process 15)</para>
        /// <para>1.2.840.10008.1.2.4.58</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGLosslessNonHierarchical15 = new DicomUid("1.2.840.10008.1.2.4.58", "JPEG Lossless, Non-Hierarchical (Process 15)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Extended, Hierarchical (Process 16 & 18)</para>
        /// <para>1.2.840.10008.1.2.4.59</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGExtendedHierarchical1618 = new DicomUid("1.2.840.10008.1.2.4.59", "JPEG Extended, Hierarchical (Process 16 & 18)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Extended, Hierarchical (Process 17 & 19)</para>
        /// <para>1.2.840.10008.1.2.4.60</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGExtendedHierarchical1719 = new DicomUid("1.2.840.10008.1.2.4.60", "JPEG Extended, Hierarchical (Process 17 & 19)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Spectral Selection, Hierarchical (Process 20 & 22)</para>
        /// <para>1.2.840.10008.1.2.4.61</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGSpectralSelectionHierarchical2022 = new DicomUid("1.2.840.10008.1.2.4.61", "JPEG Spectral Selection, Hierarchical (Process 20 & 22)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Spectral Selection, Hierarchical (Process 21 & 23)</para>
        /// <para>1.2.840.10008.1.2.4.62</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGSpectralSelectionHierarchical2123 = new DicomUid("1.2.840.10008.1.2.4.62", "JPEG Spectral Selection, Hierarchical (Process 21 & 23)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Full Progression, Hierarchical (Process 24 & 26)</para>
        /// <para>1.2.840.10008.1.2.4.63</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGFullProgressionHierarchical2426 = new DicomUid("1.2.840.10008.1.2.4.63", "JPEG Full Progression, Hierarchical (Process 24 & 26)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Full Progression, Hierarchical (Process 25 & 27)</para>
        /// <para>1.2.840.10008.1.2.4.64</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGFullProgressionHierarchical2527 = new DicomUid("1.2.840.10008.1.2.4.64", "JPEG Full Progression, Hierarchical (Process 25 & 27)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Lossless, Hierarchical (Process 28)</para>
        /// <para>1.2.840.10008.1.2.4.65</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGLosslessHierarchical28 = new DicomUid("1.2.840.10008.1.2.4.65", "JPEG Lossless, Hierarchical (Process 28)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Lossless, Hierarchical (Process 29)</para>
        /// <para>1.2.840.10008.1.2.4.66</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid JPEGLosslessHierarchical29 = new DicomUid("1.2.840.10008.1.2.4.66", "JPEG Lossless, Hierarchical (Process 29)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG Lossless, Non-Hierarchical, First-Order Prediction (Process 14 [Selection Value 1]): Default Transfer Syntax for Lossless JPEG Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.70</para>
        /// </summary>
        public static readonly DicomUid JPEGLosslessSV1 = new DicomUid("1.2.840.10008.1.2.4.70", "JPEG Lossless, Non-Hierarchical, First-Order Prediction (Process 14 [Selection Value 1]): Default Transfer Syntax for Lossless JPEG Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG-LS Lossless Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.80</para>
        /// </summary>
        public static readonly DicomUid JPEGLSLossless = new DicomUid("1.2.840.10008.1.2.4.80", "JPEG-LS Lossless Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG-LS Lossy (Near-Lossless) Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.81</para>
        /// </summary>
        public static readonly DicomUid JPEGLSNearLossless = new DicomUid("1.2.840.10008.1.2.4.81", "JPEG-LS Lossy (Near-Lossless) Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG 2000 Image Compression (Lossless Only)</para>
        /// <para>1.2.840.10008.1.2.4.90</para>
        /// </summary>
        public static readonly DicomUid JPEG2000Lossless = new DicomUid("1.2.840.10008.1.2.4.90", "JPEG 2000 Image Compression (Lossless Only)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG 2000 Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.91</para>
        /// </summary>
        public static readonly DicomUid JPEG2000 = new DicomUid("1.2.840.10008.1.2.4.91", "JPEG 2000 Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG 2000 Part 2 Multi-component Image Compression (Lossless Only)</para>
        /// <para>1.2.840.10008.1.2.4.92</para>
        /// </summary>
        public static readonly DicomUid JPEG2000MCLossless = new DicomUid("1.2.840.10008.1.2.4.92", "JPEG 2000 Part 2 Multi-component Image Compression (Lossless Only)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPEG 2000 Part 2 Multi-component Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.93</para>
        /// </summary>
        public static readonly DicomUid JPEG2000MC = new DicomUid("1.2.840.10008.1.2.4.93", "JPEG 2000 Part 2 Multi-component Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPIP Referenced</para>
        /// <para>1.2.840.10008.1.2.4.94</para>
        /// </summary>
        public static readonly DicomUid JPIPReferenced = new DicomUid("1.2.840.10008.1.2.4.94", "JPIP Referenced", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPIP Referenced Deflate</para>
        /// <para>1.2.840.10008.1.2.4.95</para>
        /// </summary>
        public static readonly DicomUid JPIPReferencedDeflate = new DicomUid("1.2.840.10008.1.2.4.95", "JPIP Referenced Deflate", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG2 Main Profile / Main Level</para>
        /// <para>1.2.840.10008.1.2.4.100</para>
        /// </summary>
        public static readonly DicomUid MPEG2MPML = new DicomUid("1.2.840.10008.1.2.4.100", "MPEG2 Main Profile / Main Level", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG2 Main Profile / Main Level</para>
        /// <para>1.2.840.10008.1.2.4.100.1</para>
        /// </summary>
        public static readonly DicomUid MPEG2MPMLF = new DicomUid("1.2.840.10008.1.2.4.100.1", "Fragmentable MPEG2 Main Profile / Main Level", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG2 Main Profile / High Level</para>
        /// <para>1.2.840.10008.1.2.4.101</para>
        /// </summary>
        public static readonly DicomUid MPEG2MPHL = new DicomUid("1.2.840.10008.1.2.4.101", "MPEG2 Main Profile / High Level", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG2 Main Profile / High Level</para>
        /// <para>1.2.840.10008.1.2.4.101.1</para>
        /// </summary>
        public static readonly DicomUid MPEG2MPHLF = new DicomUid("1.2.840.10008.1.2.4.101.1", "Fragmentable MPEG2 Main Profile / High Level", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG-4 AVC/H.264 High Profile / Level 4.1</para>
        /// <para>1.2.840.10008.1.2.4.102</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP41 = new DicomUid("1.2.840.10008.1.2.4.102", "MPEG-4 AVC/H.264 High Profile / Level 4.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.1</para>
        /// <para>1.2.840.10008.1.2.4.102.1</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP41F = new DicomUid("1.2.840.10008.1.2.4.102.1", "Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG-4 AVC/H.264 BD-compatible High Profile / Level 4.1</para>
        /// <para>1.2.840.10008.1.2.4.103</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP41BD = new DicomUid("1.2.840.10008.1.2.4.103", "MPEG-4 AVC/H.264 BD-compatible High Profile / Level 4.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG-4 AVC/H.264 BD-compatible High Profile / Level 4.1</para>
        /// <para>1.2.840.10008.1.2.4.103.1</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP41BDF = new DicomUid("1.2.840.10008.1.2.4.103.1", "Fragmentable MPEG-4 AVC/H.264 BD-compatible High Profile / Level 4.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG-4 AVC/H.264 High Profile / Level 4.2 For 2D Video</para>
        /// <para>1.2.840.10008.1.2.4.104</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP422D = new DicomUid("1.2.840.10008.1.2.4.104", "MPEG-4 AVC/H.264 High Profile / Level 4.2 For 2D Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.2 For 2D Video</para>
        /// <para>1.2.840.10008.1.2.4.104.1</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP422DF = new DicomUid("1.2.840.10008.1.2.4.104.1", "Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.2 For 2D Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG-4 AVC/H.264 High Profile / Level 4.2 For 3D Video</para>
        /// <para>1.2.840.10008.1.2.4.105</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP423D = new DicomUid("1.2.840.10008.1.2.4.105", "MPEG-4 AVC/H.264 High Profile / Level 4.2 For 3D Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.2 For 3D Video</para>
        /// <para>1.2.840.10008.1.2.4.105.1</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP423DF = new DicomUid("1.2.840.10008.1.2.4.105.1", "Fragmentable MPEG-4 AVC/H.264 High Profile / Level 4.2 For 3D Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: MPEG-4 AVC/H.264 Stereo High Profile / Level 4.2</para>
        /// <para>1.2.840.10008.1.2.4.106</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP42STEREO = new DicomUid("1.2.840.10008.1.2.4.106", "MPEG-4 AVC/H.264 Stereo High Profile / Level 4.2", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: Fragmentable MPEG-4 AVC/H.264 Stereo High Profile / Level 4.2</para>
        /// <para>1.2.840.10008.1.2.4.106.1</para>
        /// </summary>
        public static readonly DicomUid MPEG4HP42STEREOF = new DicomUid("1.2.840.10008.1.2.4.106.1", "Fragmentable MPEG-4 AVC/H.264 Stereo High Profile / Level 4.2", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: HEVC/H.265 Main Profile / Level 5.1</para>
        /// <para>1.2.840.10008.1.2.4.107</para>
        /// </summary>
        public static readonly DicomUid HEVCMP51 = new DicomUid("1.2.840.10008.1.2.4.107", "HEVC/H.265 Main Profile / Level 5.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: HEVC/H.265 Main 10 Profile / Level 5.1</para>
        /// <para>1.2.840.10008.1.2.4.108</para>
        /// </summary>
        public static readonly DicomUid HEVCM10P51 = new DicomUid("1.2.840.10008.1.2.4.108", "HEVC/H.265 Main 10 Profile / Level 5.1", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: High-Throughput JPEG 2000 Image Compression (Lossless Only)</para>
        /// <para>1.2.840.10008.1.2.4.201</para>
        /// </summary>
        public static readonly DicomUid HTJ2KLossless = new DicomUid("1.2.840.10008.1.2.4.201", "High-Throughput JPEG 2000 Image Compression (Lossless Only)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: High-Throughput JPEG 2000 with RPCL Options Image Compression (Lossless Only)</para>
        /// <para>1.2.840.10008.1.2.4.202</para>
        /// </summary>
        public static readonly DicomUid HTJ2KLosslessRPCL = new DicomUid("1.2.840.10008.1.2.4.202", "High-Throughput JPEG 2000 with RPCL Options Image Compression (Lossless Only)", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: High-Throughput JPEG 2000 Image Compression</para>
        /// <para>1.2.840.10008.1.2.4.203</para>
        /// </summary>
        public static readonly DicomUid HTJ2K = new DicomUid("1.2.840.10008.1.2.4.203", "High-Throughput JPEG 2000 Image Compression", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPIP HTJ2K Referenced</para>
        /// <para>1.2.840.10008.1.2.4.204</para>
        /// </summary>
        public static readonly DicomUid JPIPHTJ2KReferenced = new DicomUid("1.2.840.10008.1.2.4.204", "JPIP HTJ2K Referenced", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: JPIP HTJ2K Referenced Deflate</para>
        /// <para>1.2.840.10008.1.2.4.205</para>
        /// </summary>
        public static readonly DicomUid JPIPHTJ2KReferencedDeflate = new DicomUid("1.2.840.10008.1.2.4.205", "JPIP HTJ2K Referenced Deflate", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: RLE Lossless</para>
        /// <para>1.2.840.10008.1.2.5</para>
        /// </summary>
        public static readonly DicomUid RLELossless = new DicomUid("1.2.840.10008.1.2.5", "RLE Lossless", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: RFC 2557 MIME encapsulation</para>
        /// <para>1.2.840.10008.1.2.6.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2018b).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2018b).")]
        public static readonly DicomUid RFC2557MIMEEncapsulation = new DicomUid("1.2.840.10008.1.2.6.1", "RFC 2557 MIME encapsulation", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: XML Encoding</para>
        /// <para>1.2.840.10008.1.2.6.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2018b).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2018b).")]
        public static readonly DicomUid XMLEncoding = new DicomUid("1.2.840.10008.1.2.6.2", "XML Encoding", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: SMPTE ST 2110-20 Uncompressed Progressive Active Video</para>
        /// <para>1.2.840.10008.1.2.7.1</para>
        /// </summary>
        public static readonly DicomUid SMPTEST211020UncompressedProgressiveActiveVideo = new DicomUid("1.2.840.10008.1.2.7.1", "SMPTE ST 2110-20 Uncompressed Progressive Active Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: SMPTE ST 2110-20 Uncompressed Interlaced Active Video</para>
        /// <para>1.2.840.10008.1.2.7.2</para>
        /// </summary>
        public static readonly DicomUid SMPTEST211020UncompressedInterlacedActiveVideo = new DicomUid("1.2.840.10008.1.2.7.2", "SMPTE ST 2110-20 Uncompressed Interlaced Active Video", UidType.TransferSyntax);
        /// <summary>
        /// <para>Transfer Syntax: SMPTE ST 2110-30 PCM Digital Audio</para>
        /// <para>1.2.840.10008.1.2.7.3</para>
        /// </summary>
        public static readonly DicomUid SMPTEST211030PCMDigitalAudio = new DicomUid("1.2.840.10008.1.2.7.3", "SMPTE ST 2110-30 PCM Digital Audio", UidType.TransferSyntax);
        /// <summary>
        /// <para>SOP Class: Media Storage Directory Storage</para>
        /// <para>1.2.840.10008.1.3.10</para>
        /// </summary>
        public static readonly DicomUid MediaStorageDirectoryStorage = new DicomUid("1.2.840.10008.1.3.10", "Media Storage Directory Storage", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Hot Iron Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.1</para>
        /// </summary>
        public static readonly DicomUid HotIronPalette = new DicomUid("1.2.840.10008.1.5.1", "Hot Iron Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: PET Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.2</para>
        /// </summary>
        public static readonly DicomUid PETPalette = new DicomUid("1.2.840.10008.1.5.2", "PET Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Hot Metal Blue Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.3</para>
        /// </summary>
        public static readonly DicomUid HotMetalBluePalette = new DicomUid("1.2.840.10008.1.5.3", "Hot Metal Blue Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: PET 20 Step Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.4</para>
        /// </summary>
        public static readonly DicomUid PET20StepPalette = new DicomUid("1.2.840.10008.1.5.4", "PET 20 Step Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Spring Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.5</para>
        /// </summary>
        public static readonly DicomUid SpringPalette = new DicomUid("1.2.840.10008.1.5.5", "Spring Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Summer Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.6</para>
        /// </summary>
        public static readonly DicomUid SummerPalette = new DicomUid("1.2.840.10008.1.5.6", "Summer Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Fall Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.7</para>
        /// </summary>
        public static readonly DicomUid FallPalette = new DicomUid("1.2.840.10008.1.5.7", "Fall Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Winter Color Palette SOP Instance</para>
        /// <para>1.2.840.10008.1.5.8</para>
        /// </summary>
        public static readonly DicomUid WinterPalette = new DicomUid("1.2.840.10008.1.5.8", "Winter Color Palette SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Basic Study Content Notification SOP Class</para>
        /// <para>1.2.840.10008.1.9</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid BasicStudyContentNotification = new DicomUid("1.2.840.10008.1.9", "Basic Study Content Notification SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Transfer Syntax: Papyrus 3 Implicit VR Little Endian</para>
        /// <para>1.2.840.10008.1.20</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2015c).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2015c).")]
        public static readonly DicomUid Papyrus3ImplicitVRLittleEndian = new DicomUid("1.2.840.10008.1.20", "Papyrus 3 Implicit VR Little Endian", UidType.TransferSyntax);
        /// <summary>
        /// <para>SOP Class: Storage Commitment Push Model SOP Class</para>
        /// <para>1.2.840.10008.1.20.1</para>
        /// </summary>
        public static readonly DicomUid StorageCommitmentPushModel = new DicomUid("1.2.840.10008.1.20.1", "Storage Commitment Push Model SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Storage Commitment Push Model SOP Instance</para>
        /// <para>1.2.840.10008.1.20.1.1</para>
        /// </summary>
        public static readonly DicomUid StorageCommitmentPushModelInstance = new DicomUid("1.2.840.10008.1.20.1.1", "Storage Commitment Push Model SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Storage Commitment Pull Model SOP Class</para>
        /// <para>1.2.840.10008.1.20.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid StorageCommitmentPullModel = new DicomUid("1.2.840.10008.1.20.2", "Storage Commitment Pull Model SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Storage Commitment Pull Model SOP Instance</para>
        /// <para>1.2.840.10008.1.20.2.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2001).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2001).")]
        public static readonly DicomUid StorageCommitmentPullModelInstance = new DicomUid("1.2.840.10008.1.20.2.1", "Storage Commitment Pull Model SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Procedural Event Logging SOP Class</para>
        /// <para>1.2.840.10008.1.40</para>
        /// </summary>
        public static readonly DicomUid ProceduralEventLogging = new DicomUid("1.2.840.10008.1.40", "Procedural Event Logging SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Procedural Event Logging SOP Instance</para>
        /// <para>1.2.840.10008.1.40.1</para>
        /// </summary>
        public static readonly DicomUid ProceduralEventLoggingInstance = new DicomUid("1.2.840.10008.1.40.1", "Procedural Event Logging SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Substance Administration Logging SOP Class</para>
        /// <para>1.2.840.10008.1.42</para>
        /// </summary>
        public static readonly DicomUid SubstanceAdministrationLogging = new DicomUid("1.2.840.10008.1.42", "Substance Administration Logging SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Substance Administration Logging SOP Instance</para>
        /// <para>1.2.840.10008.1.42.1</para>
        /// </summary>
        public static readonly DicomUid SubstanceAdministrationLoggingInstance = new DicomUid("1.2.840.10008.1.42.1", "Substance Administration Logging SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>DICOM UIDs as a Coding Scheme: DICOM UID Registry</para>
        /// <para>1.2.840.10008.2.6.1</para>
        /// </summary>
        public static readonly DicomUid DCMUID = new DicomUid("1.2.840.10008.2.6.1", "DICOM UID Registry", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: DICOM Controlled Terminology</para>
        /// <para>1.2.840.10008.2.16.4</para>
        /// </summary>
        public static readonly DicomUid DCM = new DicomUid("1.2.840.10008.2.16.4", "DICOM Controlled Terminology", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Adult Mouse Anatomy Ontology</para>
        /// <para>1.2.840.10008.2.16.5</para>
        /// </summary>
        public static readonly DicomUid MA = new DicomUid("1.2.840.10008.2.16.5", "Adult Mouse Anatomy Ontology", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Uberon Ontology</para>
        /// <para>1.2.840.10008.2.16.6</para>
        /// </summary>
        public static readonly DicomUid UBERON = new DicomUid("1.2.840.10008.2.16.6", "Uberon Ontology", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Integrated Taxonomic Information System (ITIS) Taxonomic Serial Number (TSN)</para>
        /// <para>1.2.840.10008.2.16.7</para>
        /// </summary>
        public static readonly DicomUid ITIS_TSN = new DicomUid("1.2.840.10008.2.16.7", "Integrated Taxonomic Information System (ITIS) Taxonomic Serial Number (TSN)", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Mouse Genome Initiative (MGI)</para>
        /// <para>1.2.840.10008.2.16.8</para>
        /// </summary>
        public static readonly DicomUid MGI = new DicomUid("1.2.840.10008.2.16.8", "Mouse Genome Initiative (MGI)", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Pub​Chem Compound CID</para>
        /// <para>1.2.840.10008.2.16.9</para>
        /// </summary>
        public static readonly DicomUid PUBCHEM_CID = new DicomUid("1.2.840.10008.2.16.9", "Pub​Chem Compound CID", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Dublin Core</para>
        /// <para>1.2.840.10008.2.16.10</para>
        /// </summary>
        public static readonly DicomUid DC = new DicomUid("1.2.840.10008.2.16.10", "Dublin Core", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: New York University Melanoma Clinical Cooperative Group</para>
        /// <para>1.2.840.10008.2.16.11</para>
        /// </summary>
        public static readonly DicomUid NYUMCCG = new DicomUid("1.2.840.10008.2.16.11", "New York University Melanoma Clinical Cooperative Group", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Mayo Clinic Non-radiological Images Specific Body Structure Anatomical Surface Region Guide</para>
        /// <para>1.2.840.10008.2.16.12</para>
        /// </summary>
        public static readonly DicomUid MAYONRISBSASRG = new DicomUid("1.2.840.10008.2.16.12", "Mayo Clinic Non-radiological Images Specific Body Structure Anatomical Surface Region Guide", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Image Biomarker Standardisation Initiative</para>
        /// <para>1.2.840.10008.2.16.13</para>
        /// </summary>
        public static readonly DicomUid IBSI = new DicomUid("1.2.840.10008.2.16.13", "Image Biomarker Standardisation Initiative", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Radiomics Ontology</para>
        /// <para>1.2.840.10008.2.16.14</para>
        /// </summary>
        public static readonly DicomUid RO = new DicomUid("1.2.840.10008.2.16.14", "Radiomics Ontology", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: RadElement</para>
        /// <para>1.2.840.10008.2.16.15</para>
        /// </summary>
        public static readonly DicomUid RADELEMENT = new DicomUid("1.2.840.10008.2.16.15", "RadElement", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: ICD-11</para>
        /// <para>1.2.840.10008.2.16.16</para>
        /// </summary>
        public static readonly DicomUid I11 = new DicomUid("1.2.840.10008.2.16.16", "ICD-11", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Unified numbering system (UNS) for metals and alloys</para>
        /// <para>1.2.840.10008.2.16.17</para>
        /// </summary>
        public static readonly DicomUid UNS = new DicomUid("1.2.840.10008.2.16.17", "Unified numbering system (UNS) for metals and alloys", UidType.CodingScheme);
        /// <summary>
        /// <para>Coding Scheme: Research Resource Identification</para>
        /// <para>1.2.840.10008.2.16.18</para>
        /// </summary>
        public static readonly DicomUid RRID = new DicomUid("1.2.840.10008.2.16.18", "Research Resource Identification", UidType.CodingScheme);
        /// <summary>
        /// <para>Application Context Name: DICOM Application Context Name</para>
        /// <para>1.2.840.10008.3.1.1.1</para>
        /// </summary>
        public static readonly DicomUid DICOMApplicationContext = new DicomUid("1.2.840.10008.3.1.1.1", "DICOM Application Context Name", UidType.ApplicationContextName);
        /// <summary>
        /// <para>SOP Class: Detached Patient Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.1.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedPatientManagement = new DicomUid("1.2.840.10008.3.1.2.1.1", "Detached Patient Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Detached Patient Management Meta SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.1.4</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedPatientManagementMeta = new DicomUid("1.2.840.10008.3.1.2.1.4", "Detached Patient Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: Detached Visit Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.2.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedVisitManagement = new DicomUid("1.2.840.10008.3.1.2.2.1", "Detached Visit Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Detached Study Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.3.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedStudyManagement = new DicomUid("1.2.840.10008.3.1.2.3.1", "Detached Study Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Study Component Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.3.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StudyComponentManagement = new DicomUid("1.2.840.10008.3.1.2.3.2", "Study Component Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Modality Performed Procedure Step SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.3.3</para>
        /// </summary>
        public static readonly DicomUid ModalityPerformedProcedureStep = new DicomUid("1.2.840.10008.3.1.2.3.3", "Modality Performed Procedure Step SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Modality Performed Procedure Step Retrieve SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.3.4</para>
        /// </summary>
        public static readonly DicomUid ModalityPerformedProcedureStepRetrieve = new DicomUid("1.2.840.10008.3.1.2.3.4", "Modality Performed Procedure Step Retrieve SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Modality Performed Procedure Step Notification SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.3.5</para>
        /// </summary>
        public static readonly DicomUid ModalityPerformedProcedureStepNotification = new DicomUid("1.2.840.10008.3.1.2.3.5", "Modality Performed Procedure Step Notification SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Detached Results Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.5.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedResultsManagement = new DicomUid("1.2.840.10008.3.1.2.5.1", "Detached Results Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Detached Results Management Meta SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.5.4</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedResultsManagementMeta = new DicomUid("1.2.840.10008.3.1.2.5.4", "Detached Results Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Detached Study Management Meta SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.5.5</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedStudyManagementMeta = new DicomUid("1.2.840.10008.3.1.2.5.5", "Detached Study Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: Detached Interpretation Management SOP Class</para>
        /// <para>1.2.840.10008.3.1.2.6.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid DetachedInterpretationManagement = new DicomUid("1.2.840.10008.3.1.2.6.1", "Detached Interpretation Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Service Class: Storage Service Class</para>
        /// <para>1.2.840.10008.4.2</para>
        /// </summary>
        public static readonly DicomUid Storage = new DicomUid("1.2.840.10008.4.2", "Storage Service Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Film Session SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.1</para>
        /// </summary>
        public static readonly DicomUid BasicFilmSession = new DicomUid("1.2.840.10008.5.1.1.1", "Basic Film Session SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Film Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.2</para>
        /// </summary>
        public static readonly DicomUid BasicFilmBox = new DicomUid("1.2.840.10008.5.1.1.2", "Basic Film Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Grayscale Image Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.4</para>
        /// </summary>
        public static readonly DicomUid BasicGrayscaleImageBox = new DicomUid("1.2.840.10008.5.1.1.4", "Basic Grayscale Image Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Color Image Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.4.1</para>
        /// </summary>
        public static readonly DicomUid BasicColorImageBox = new DicomUid("1.2.840.10008.5.1.1.4.1", "Basic Color Image Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Referenced Image Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.4.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid ReferencedImageBox = new DicomUid("1.2.840.10008.5.1.1.4.2", "Referenced Image Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Basic Grayscale Print Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.9</para>
        /// </summary>
        public static readonly DicomUid BasicGrayscalePrintManagementMeta = new DicomUid("1.2.840.10008.5.1.1.9", "Basic Grayscale Print Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Referenced Grayscale Print Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.9.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid ReferencedGrayscalePrintManagementMeta = new DicomUid("1.2.840.10008.5.1.1.9.1", "Referenced Grayscale Print Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: Print Job SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.14</para>
        /// </summary>
        public static readonly DicomUid PrintJob = new DicomUid("1.2.840.10008.5.1.1.14", "Print Job SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Annotation Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.15</para>
        /// </summary>
        public static readonly DicomUid BasicAnnotationBox = new DicomUid("1.2.840.10008.5.1.1.15", "Basic Annotation Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Printer SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.16</para>
        /// </summary>
        public static readonly DicomUid Printer = new DicomUid("1.2.840.10008.5.1.1.16", "Printer SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Printer Configuration Retrieval SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.16.376</para>
        /// </summary>
        public static readonly DicomUid PrinterConfigurationRetrieval = new DicomUid("1.2.840.10008.5.1.1.16.376", "Printer Configuration Retrieval SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Printer SOP Instance</para>
        /// <para>1.2.840.10008.5.1.1.17</para>
        /// </summary>
        public static readonly DicomUid PrinterInstance = new DicomUid("1.2.840.10008.5.1.1.17", "Printer SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: Printer Configuration Retrieval SOP Instance</para>
        /// <para>1.2.840.10008.5.1.1.17.376</para>
        /// </summary>
        public static readonly DicomUid PrinterConfigurationRetrievalInstance = new DicomUid("1.2.840.10008.5.1.1.17.376", "Printer Configuration Retrieval SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Meta SOP Class: Basic Color Print Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.18</para>
        /// </summary>
        public static readonly DicomUid BasicColorPrintManagementMeta = new DicomUid("1.2.840.10008.5.1.1.18", "Basic Color Print Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Referenced Color Print Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.18.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid ReferencedColorPrintManagementMeta = new DicomUid("1.2.840.10008.5.1.1.18.1", "Referenced Color Print Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: VOI LUT Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.22</para>
        /// </summary>
        public static readonly DicomUid VOILUTBox = new DicomUid("1.2.840.10008.5.1.1.22", "VOI LUT Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Presentation LUT SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.23</para>
        /// </summary>
        public static readonly DicomUid PresentationLUT = new DicomUid("1.2.840.10008.5.1.1.23", "Presentation LUT SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Image Overlay Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.24</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid ImageOverlayBox = new DicomUid("1.2.840.10008.5.1.1.24", "Image Overlay Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Print Image Overlay Box SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.24.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid BasicPrintImageOverlayBox = new DicomUid("1.2.840.10008.5.1.1.24.1", "Basic Print Image Overlay Box SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Print Queue SOP Instance</para>
        /// <para>1.2.840.10008.5.1.1.25</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PrintQueueInstance = new DicomUid("1.2.840.10008.5.1.1.25", "Print Queue SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Print Queue Management SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.26</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PrintQueueManagement = new DicomUid("1.2.840.10008.5.1.1.26", "Print Queue Management SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Stored Print Storage SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.27</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StoredPrintStorage = new DicomUid("1.2.840.10008.5.1.1.27", "Stored Print Storage SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hardcopy Grayscale Image Storage SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.29</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid HardcopyGrayscaleImageStorage = new DicomUid("1.2.840.10008.5.1.1.29", "Hardcopy Grayscale Image Storage SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hardcopy Color Image Storage SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.30</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid HardcopyColorImageStorage = new DicomUid("1.2.840.10008.5.1.1.30", "Hardcopy Color Image Storage SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Pull Print Request SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.31</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PullPrintRequest = new DicomUid("1.2.840.10008.5.1.1.31", "Pull Print Request SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Meta SOP Class: Pull Stored Print Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.32</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PullStoredPrintManagementMeta = new DicomUid("1.2.840.10008.5.1.1.32", "Pull Stored Print Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: Media Creation Management SOP Class UID</para>
        /// <para>1.2.840.10008.5.1.1.33</para>
        /// </summary>
        public static readonly DicomUid MediaCreationManagement = new DicomUid("1.2.840.10008.5.1.1.33", "Media Creation Management SOP Class UID", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Display System SOP Class</para>
        /// <para>1.2.840.10008.5.1.1.40</para>
        /// </summary>
        public static readonly DicomUid DisplaySystem = new DicomUid("1.2.840.10008.5.1.1.40", "Display System SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Display System SOP Instance</para>
        /// <para>1.2.840.10008.5.1.1.40.1</para>
        /// </summary>
        public static readonly DicomUid DisplaySystemInstance = new DicomUid("1.2.840.10008.5.1.1.40.1", "Display System SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: Computed Radiography Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1</para>
        /// </summary>
        public static readonly DicomUid ComputedRadiographyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.1", "Computed Radiography Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital X-Ray Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.1</para>
        /// </summary>
        public static readonly DicomUid DigitalXRayImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.1.1", "Digital X-Ray Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital X-Ray Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.1.1</para>
        /// </summary>
        public static readonly DicomUid DigitalXRayImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.1.1.1", "Digital X-Ray Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital Mammography X-Ray Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.2</para>
        /// </summary>
        public static readonly DicomUid DigitalMammographyXRayImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.1.2", "Digital Mammography X-Ray Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital Mammography X-Ray Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.2.1</para>
        /// </summary>
        public static readonly DicomUid DigitalMammographyXRayImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.1.2.1", "Digital Mammography X-Ray Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital Intra-Oral X-Ray Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.3</para>
        /// </summary>
        public static readonly DicomUid DigitalIntraOralXRayImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.1.3", "Digital Intra-Oral X-Ray Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Digital Intra-Oral X-Ray Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.1.3.1</para>
        /// </summary>
        public static readonly DicomUid DigitalIntraOralXRayImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.1.3.1", "Digital Intra-Oral X-Ray Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: CT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.2</para>
        /// </summary>
        public static readonly DicomUid CTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.2", "CT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced CT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.2.1</para>
        /// </summary>
        public static readonly DicomUid EnhancedCTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.2.1", "Enhanced CT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Legacy Converted Enhanced CT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.2.2</para>
        /// </summary>
        public static readonly DicomUid LegacyConvertedEnhancedCTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.2.2", "Legacy Converted Enhanced CT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ultrasound Multi-frame Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1993).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1993).")]
        public static readonly DicomUid UltrasoundMultiFrameImageStorageRetired = new DicomUid("1.2.840.10008.5.1.4.1.1.3", "Ultrasound Multi-frame Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ultrasound Multi-frame Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.3.1</para>
        /// </summary>
        public static readonly DicomUid UltrasoundMultiFrameImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.3.1", "Ultrasound Multi-frame Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: MR Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.4</para>
        /// </summary>
        public static readonly DicomUid MRImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.4", "MR Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced MR Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.4.1</para>
        /// </summary>
        public static readonly DicomUid EnhancedMRImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.4.1", "Enhanced MR Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: MR Spectroscopy Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.4.2</para>
        /// </summary>
        public static readonly DicomUid MRSpectroscopyStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.4.2", "MR Spectroscopy Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced MR Color Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.4.3</para>
        /// </summary>
        public static readonly DicomUid EnhancedMRColorImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.4.3", "Enhanced MR Color Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Legacy Converted Enhanced MR Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.4.4</para>
        /// </summary>
        public static readonly DicomUid LegacyConvertedEnhancedMRImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.4.4", "Legacy Converted Enhanced MR Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Nuclear Medicine Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.5</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1993).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1993).")]
        public static readonly DicomUid NuclearMedicineImageStorageRetired = new DicomUid("1.2.840.10008.5.1.4.1.1.5", "Nuclear Medicine Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ultrasound Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.6</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1993).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1993).")]
        public static readonly DicomUid UltrasoundImageStorageRetired = new DicomUid("1.2.840.10008.5.1.4.1.1.6", "Ultrasound Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ultrasound Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.6.1</para>
        /// </summary>
        public static readonly DicomUid UltrasoundImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.6.1", "Ultrasound Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced US Volume Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.6.2</para>
        /// </summary>
        public static readonly DicomUid EnhancedUSVolumeStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.6.2", "Enhanced US Volume Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Photoacoustic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.6.3</para>
        /// </summary>
        public static readonly DicomUid PhotoacousticImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.6.3", "Photoacoustic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Secondary Capture Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.7</para>
        /// </summary>
        public static readonly DicomUid SecondaryCaptureImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.7", "Secondary Capture Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multi-frame Single Bit Secondary Capture Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.7.1</para>
        /// </summary>
        public static readonly DicomUid MultiFrameSingleBitSecondaryCaptureImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.7.1", "Multi-frame Single Bit Secondary Capture Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multi-frame Grayscale Byte Secondary Capture Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.7.2</para>
        /// </summary>
        public static readonly DicomUid MultiFrameGrayscaleByteSecondaryCaptureImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.7.2", "Multi-frame Grayscale Byte Secondary Capture Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multi-frame Grayscale Word Secondary Capture Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.7.3</para>
        /// </summary>
        public static readonly DicomUid MultiFrameGrayscaleWordSecondaryCaptureImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.7.3", "Multi-frame Grayscale Word Secondary Capture Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multi-frame True Color Secondary Capture Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.7.4</para>
        /// </summary>
        public static readonly DicomUid MultiFrameTrueColorSecondaryCaptureImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.7.4", "Multi-frame True Color Secondary Capture Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Standalone Overlay Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.8</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StandaloneOverlayStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.8", "Standalone Overlay Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Standalone Curve Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StandaloneCurveStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9", "Standalone Curve Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Waveform Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2007).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2007).")]
        public static readonly DicomUid WaveformStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.9.1", "Waveform Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: 12-lead ECG Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.1.1</para>
        /// </summary>
        public static readonly DicomUid TwelveLeadECGWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.1.1", "12-lead ECG Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General ECG Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.1.2</para>
        /// </summary>
        public static readonly DicomUid GeneralECGWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.1.2", "General ECG Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ambulatory ECG Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.1.3</para>
        /// </summary>
        public static readonly DicomUid AmbulatoryECGWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.1.3", "Ambulatory ECG Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General 32-bit ECG Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.1.4</para>
        /// </summary>
        public static readonly DicomUid General32bitECGWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.1.4", "General 32-bit ECG Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hemodynamic Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.2.1</para>
        /// </summary>
        public static readonly DicomUid HemodynamicWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.2.1", "Hemodynamic Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Cardiac Electrophysiology Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.3.1</para>
        /// </summary>
        public static readonly DicomUid CardiacElectrophysiologyWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.3.1", "Cardiac Electrophysiology Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Voice Audio Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.4.1</para>
        /// </summary>
        public static readonly DicomUid BasicVoiceAudioWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.4.1", "Basic Voice Audio Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General Audio Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.4.2</para>
        /// </summary>
        public static readonly DicomUid GeneralAudioWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.4.2", "General Audio Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Arterial Pulse Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.5.1</para>
        /// </summary>
        public static readonly DicomUid ArterialPulseWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.5.1", "Arterial Pulse Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Respiratory Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.6.1</para>
        /// </summary>
        public static readonly DicomUid RespiratoryWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.6.1", "Respiratory Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multi-channel Respiratory Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.6.2</para>
        /// </summary>
        public static readonly DicomUid MultichannelRespiratoryWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.6.2", "Multi-channel Respiratory Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Routine Scalp Electroencephalogram Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.7.1</para>
        /// </summary>
        public static readonly DicomUid RoutineScalpElectroencephalogramWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.7.1", "Routine Scalp Electroencephalogram Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Electromyogram Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.7.2</para>
        /// </summary>
        public static readonly DicomUid ElectromyogramWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.7.2", "Electromyogram Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Electrooculogram Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.7.3</para>
        /// </summary>
        public static readonly DicomUid ElectrooculogramWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.7.3", "Electrooculogram Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Sleep Electroencephalogram Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.7.4</para>
        /// </summary>
        public static readonly DicomUid SleepElectroencephalogramWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.7.4", "Sleep Electroencephalogram Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Body Position Waveform Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.9.8.1</para>
        /// </summary>
        public static readonly DicomUid BodyPositionWaveformStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.9.8.1", "Body Position Waveform Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Standalone Modality LUT Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.10</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StandaloneModalityLUTStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.10", "Standalone Modality LUT Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Standalone VOI LUT Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StandaloneVOILUTStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11", "Standalone VOI LUT Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Grayscale Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.1</para>
        /// </summary>
        public static readonly DicomUid GrayscaleSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.1", "Grayscale Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Color Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.2</para>
        /// </summary>
        public static readonly DicomUid ColorSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.2", "Color Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Pseudo-Color Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.3</para>
        /// </summary>
        public static readonly DicomUid PseudoColorSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.3", "Pseudo-Color Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Blending Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.4</para>
        /// </summary>
        public static readonly DicomUid BlendingSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.4", "Blending Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: XA/XRF Grayscale Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.5</para>
        /// </summary>
        public static readonly DicomUid XAXRFGrayscaleSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.5", "XA/XRF Grayscale Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Grayscale Planar MPR Volumetric Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.6</para>
        /// </summary>
        public static readonly DicomUid GrayscalePlanarMPRVolumetricPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.6", "Grayscale Planar MPR Volumetric Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Compositing Planar MPR Volumetric Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.7</para>
        /// </summary>
        public static readonly DicomUid CompositingPlanarMPRVolumetricPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.7", "Compositing Planar MPR Volumetric Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Advanced Blending Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.8</para>
        /// </summary>
        public static readonly DicomUid AdvancedBlendingPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.8", "Advanced Blending Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Volume Rendering Volumetric Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.9</para>
        /// </summary>
        public static readonly DicomUid VolumeRenderingVolumetricPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.9", "Volume Rendering Volumetric Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Segmented Volume Rendering Volumetric Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.10</para>
        /// </summary>
        public static readonly DicomUid SegmentedVolumeRenderingVolumetricPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.10", "Segmented Volume Rendering Volumetric Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Multiple Volume Rendering Volumetric Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.11</para>
        /// </summary>
        public static readonly DicomUid MultipleVolumeRenderingVolumetricPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.11", "Multiple Volume Rendering Volumetric Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Variable Modality LUT Softcopy Presentation State Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.11.12</para>
        /// </summary>
        public static readonly DicomUid VariableModalityLUTSoftcopyPresentationStateStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.11.12", "Variable Modality LUT Softcopy Presentation State Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray Angiographic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.12.1</para>
        /// </summary>
        public static readonly DicomUid XRayAngiographicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.12.1", "X-Ray Angiographic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced XA Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.12.1.1</para>
        /// </summary>
        public static readonly DicomUid EnhancedXAImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.12.1.1", "Enhanced XA Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray Radiofluoroscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.12.2</para>
        /// </summary>
        public static readonly DicomUid XRayRadiofluoroscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.12.2", "X-Ray Radiofluoroscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced XRF Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.12.2.1</para>
        /// </summary>
        public static readonly DicomUid EnhancedXRFImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.12.2.1", "Enhanced XRF Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray Angiographic Bi-Plane Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.12.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid XRayAngiographicBiPlaneImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.12.3", "X-Ray Angiographic Bi-Plane Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray 3D Angiographic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.13.1.1</para>
        /// </summary>
        public static readonly DicomUid XRay3DAngiographicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.13.1.1", "X-Ray 3D Angiographic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray 3D Craniofacial Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.13.1.2</para>
        /// </summary>
        public static readonly DicomUid XRay3DCraniofacialImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.13.1.2", "X-Ray 3D Craniofacial Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Breast Tomosynthesis Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.13.1.3</para>
        /// </summary>
        public static readonly DicomUid BreastTomosynthesisImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.13.1.3", "Breast Tomosynthesis Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Breast Projection X-Ray Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.13.1.4</para>
        /// </summary>
        public static readonly DicomUid BreastProjectionXRayImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.13.1.4", "Breast Projection X-Ray Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Breast Projection X-Ray Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.13.1.5</para>
        /// </summary>
        public static readonly DicomUid BreastProjectionXRayImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.13.1.5", "Breast Projection X-Ray Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Intravascular Optical Coherence Tomography Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.14.1</para>
        /// </summary>
        public static readonly DicomUid IntravascularOpticalCoherenceTomographyImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.14.1", "Intravascular Optical Coherence Tomography Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Intravascular Optical Coherence Tomography Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.14.2</para>
        /// </summary>
        public static readonly DicomUid IntravascularOpticalCoherenceTomographyImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.14.2", "Intravascular Optical Coherence Tomography Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Nuclear Medicine Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.20</para>
        /// </summary>
        public static readonly DicomUid NuclearMedicineImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.20", "Nuclear Medicine Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Parametric Map Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.30</para>
        /// </summary>
        public static readonly DicomUid ParametricMapStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.30", "Parametric Map Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Raw Data Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66</para>
        /// </summary>
        public static readonly DicomUid RawDataStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66", "Raw Data Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Spatial Registration Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.1</para>
        /// </summary>
        public static readonly DicomUid SpatialRegistrationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.1", "Spatial Registration Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Spatial Fiducials Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.2</para>
        /// </summary>
        public static readonly DicomUid SpatialFiducialsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.2", "Spatial Fiducials Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Deformable Spatial Registration Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.3</para>
        /// </summary>
        public static readonly DicomUid DeformableSpatialRegistrationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.3", "Deformable Spatial Registration Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Segmentation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.4</para>
        /// </summary>
        public static readonly DicomUid SegmentationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.4", "Segmentation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Surface Segmentation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.5</para>
        /// </summary>
        public static readonly DicomUid SurfaceSegmentationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.5", "Surface Segmentation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Tractography Results Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.66.6</para>
        /// </summary>
        public static readonly DicomUid TractographyResultsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.66.6", "Tractography Results Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Real World Value Mapping Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.67</para>
        /// </summary>
        public static readonly DicomUid RealWorldValueMappingStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.67", "Real World Value Mapping Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Surface Scan Mesh Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.68.1</para>
        /// </summary>
        public static readonly DicomUid SurfaceScanMeshStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.68.1", "Surface Scan Mesh Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Surface Scan Point Cloud Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.68.2</para>
        /// </summary>
        public static readonly DicomUid SurfaceScanPointCloudStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.68.2", "Surface Scan Point Cloud Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Image Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid VLImageStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1", "VL Image Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Multi-frame Image Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (1998).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (1998).")]
        public static readonly DicomUid VLMultiFrameImageStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.77.2", "VL Multi-frame Image Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Endoscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.1</para>
        /// </summary>
        public static readonly DicomUid VLEndoscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.1", "VL Endoscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Video Endoscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.1.1</para>
        /// </summary>
        public static readonly DicomUid VideoEndoscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.1.1", "Video Endoscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Microscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.2</para>
        /// </summary>
        public static readonly DicomUid VLMicroscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.2", "VL Microscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Video Microscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.2.1</para>
        /// </summary>
        public static readonly DicomUid VideoMicroscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.2.1", "Video Microscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Slide-Coordinates Microscopic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.3</para>
        /// </summary>
        public static readonly DicomUid VLSlideCoordinatesMicroscopicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.3", "VL Slide-Coordinates Microscopic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Photographic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.4</para>
        /// </summary>
        public static readonly DicomUid VLPhotographicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.4", "VL Photographic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Video Photographic Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.4.1</para>
        /// </summary>
        public static readonly DicomUid VideoPhotographicImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.4.1", "Video Photographic Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Photography 8 Bit Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.1</para>
        /// </summary>
        public static readonly DicomUid OphthalmicPhotography8BitImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.1", "Ophthalmic Photography 8 Bit Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Photography 16 Bit Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.2</para>
        /// </summary>
        public static readonly DicomUid OphthalmicPhotography16BitImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.2", "Ophthalmic Photography 16 Bit Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Stereometric Relationship Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.3</para>
        /// </summary>
        public static readonly DicomUid StereometricRelationshipStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.3", "Stereometric Relationship Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Tomography Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.4</para>
        /// </summary>
        public static readonly DicomUid OphthalmicTomographyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.4", "Ophthalmic Tomography Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Wide Field Ophthalmic Photography Stereographic Projection Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.5</para>
        /// </summary>
        public static readonly DicomUid WideFieldOphthalmicPhotographyStereographicProjectionImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.5", "Wide Field Ophthalmic Photography Stereographic Projection Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Wide Field Ophthalmic Photography 3D Coordinates Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.6</para>
        /// </summary>
        public static readonly DicomUid WideFieldOphthalmicPhotography3DCoordinatesImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.6", "Wide Field Ophthalmic Photography 3D Coordinates Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Optical Coherence Tomography En Face Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.7</para>
        /// </summary>
        public static readonly DicomUid OphthalmicOpticalCoherenceTomographyEnFaceImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.7", "Ophthalmic Optical Coherence Tomography En Face Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Optical Coherence Tomography B-scan Volume Analysis Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.5.8</para>
        /// </summary>
        public static readonly DicomUid OphthalmicOpticalCoherenceTomographyBscanVolumeAnalysisStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.5.8", "Ophthalmic Optical Coherence Tomography B-scan Volume Analysis Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: VL Whole Slide Microscopy Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.6</para>
        /// </summary>
        public static readonly DicomUid VLWholeSlideMicroscopyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.6", "VL Whole Slide Microscopy Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Dermoscopic Photography Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.7</para>
        /// </summary>
        public static readonly DicomUid DermoscopicPhotographyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.7", "Dermoscopic Photography Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Confocal Microscopy Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.8</para>
        /// </summary>
        public static readonly DicomUid ConfocalMicroscopyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.8", "Confocal Microscopy Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Confocal Microscopy Tiled Pyramidal Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.77.1.9</para>
        /// </summary>
        public static readonly DicomUid ConfocalMicroscopyTiledPyramidalImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.77.1.9", "Confocal Microscopy Tiled Pyramidal Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Lensometry Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.1</para>
        /// </summary>
        public static readonly DicomUid LensometryMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.1", "Lensometry Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Autorefraction Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.2</para>
        /// </summary>
        public static readonly DicomUid AutorefractionMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.2", "Autorefraction Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Keratometry Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.3</para>
        /// </summary>
        public static readonly DicomUid KeratometryMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.3", "Keratometry Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Subjective Refraction Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.4</para>
        /// </summary>
        public static readonly DicomUid SubjectiveRefractionMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.4", "Subjective Refraction Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Visual Acuity Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.5</para>
        /// </summary>
        public static readonly DicomUid VisualAcuityMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.5", "Visual Acuity Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Spectacle Prescription Report Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.6</para>
        /// </summary>
        public static readonly DicomUid SpectaclePrescriptionReportStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.6", "Spectacle Prescription Report Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Axial Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.7</para>
        /// </summary>
        public static readonly DicomUid OphthalmicAxialMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.7", "Ophthalmic Axial Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Intraocular Lens Calculations Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.78.8</para>
        /// </summary>
        public static readonly DicomUid IntraocularLensCalculationsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.78.8", "Intraocular Lens Calculations Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Macular Grid Thickness and Volume Report Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.79.1</para>
        /// </summary>
        public static readonly DicomUid MacularGridThicknessAndVolumeReportStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.79.1", "Macular Grid Thickness and Volume Report Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Visual Field Static Perimetry Measurements Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.80.1</para>
        /// </summary>
        public static readonly DicomUid OphthalmicVisualFieldStaticPerimetryMeasurementsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.80.1", "Ophthalmic Visual Field Static Perimetry Measurements Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Ophthalmic Thickness Map Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.81.1</para>
        /// </summary>
        public static readonly DicomUid OphthalmicThicknessMapStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.81.1", "Ophthalmic Thickness Map Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Corneal Topography Map Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.82.1</para>
        /// </summary>
        public static readonly DicomUid CornealTopographyMapStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.82.1", "Corneal Topography Map Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Text SR Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2007).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2007).")]
        public static readonly DicomUid TextSRStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.88.1", "Text SR Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Audio SR Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2007).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2007).")]
        public static readonly DicomUid AudioSRStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.88.2", "Audio SR Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Detail SR Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2007).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2007).")]
        public static readonly DicomUid DetailSRStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.88.3", "Detail SR Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Comprehensive SR Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.4</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2007).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2007).")]
        public static readonly DicomUid ComprehensiveSRStorageTrial = new DicomUid("1.2.840.10008.5.1.4.1.1.88.4", "Comprehensive SR Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Text SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.11</para>
        /// </summary>
        public static readonly DicomUid BasicTextSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.11", "Basic Text SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.22</para>
        /// </summary>
        public static readonly DicomUid EnhancedSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.22", "Enhanced SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Comprehensive SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.33</para>
        /// </summary>
        public static readonly DicomUid ComprehensiveSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.33", "Comprehensive SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Comprehensive 3D SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.34</para>
        /// </summary>
        public static readonly DicomUid Comprehensive3DSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.34", "Comprehensive 3D SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Extensible SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.35</para>
        /// </summary>
        public static readonly DicomUid ExtensibleSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.35", "Extensible SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Procedure Log Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.40</para>
        /// </summary>
        public static readonly DicomUid ProcedureLogStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.40", "Procedure Log Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Mammography CAD SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.50</para>
        /// </summary>
        public static readonly DicomUid MammographyCADSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.50", "Mammography CAD SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Key Object Selection Document Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.59</para>
        /// </summary>
        public static readonly DicomUid KeyObjectSelectionDocumentStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.59", "Key Object Selection Document Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Chest CAD SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.65</para>
        /// </summary>
        public static readonly DicomUid ChestCADSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.65", "Chest CAD SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: X-Ray Radiation Dose SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.67</para>
        /// </summary>
        public static readonly DicomUid XRayRadiationDoseSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.67", "X-Ray Radiation Dose SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Radiopharmaceutical Radiation Dose SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.68</para>
        /// </summary>
        public static readonly DicomUid RadiopharmaceuticalRadiationDoseSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.68", "Radiopharmaceutical Radiation Dose SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Colon CAD SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.69</para>
        /// </summary>
        public static readonly DicomUid ColonCADSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.69", "Colon CAD SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implantation Plan SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.70</para>
        /// </summary>
        public static readonly DicomUid ImplantationPlanSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.70", "Implantation Plan SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Acquisition Context SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.71</para>
        /// </summary>
        public static readonly DicomUid AcquisitionContextSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.71", "Acquisition Context SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Simplified Adult Echo SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.72</para>
        /// </summary>
        public static readonly DicomUid SimplifiedAdultEchoSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.72", "Simplified Adult Echo SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient Radiation Dose SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.73</para>
        /// </summary>
        public static readonly DicomUid PatientRadiationDoseSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.73", "Patient Radiation Dose SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Planned Imaging Agent Administration SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.74</para>
        /// </summary>
        public static readonly DicomUid PlannedImagingAgentAdministrationSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.74", "Planned Imaging Agent Administration SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Performed Imaging Agent Administration SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.75</para>
        /// </summary>
        public static readonly DicomUid PerformedImagingAgentAdministrationSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.75", "Performed Imaging Agent Administration SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced X-Ray Radiation Dose SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.76</para>
        /// </summary>
        public static readonly DicomUid EnhancedXRayRadiationDoseSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.76", "Enhanced X-Ray Radiation Dose SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Waveform Annotation SR Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.88.77</para>
        /// </summary>
        public static readonly DicomUid WaveformAnnotationSRStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.88.77", "Waveform Annotation SR Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Content Assessment Results Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.90.1</para>
        /// </summary>
        public static readonly DicomUid ContentAssessmentResultsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.90.1", "Content Assessment Results Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Microscopy Bulk Simple Annotations Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.91.1</para>
        /// </summary>
        public static readonly DicomUid MicroscopyBulkSimpleAnnotationsStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.91.1", "Microscopy Bulk Simple Annotations Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Encapsulated PDF Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.104.1</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedPDFStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.104.1", "Encapsulated PDF Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Encapsulated CDA Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.104.2</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedCDAStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.104.2", "Encapsulated CDA Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Encapsulated STL Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.104.3</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedSTLStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.104.3", "Encapsulated STL Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Encapsulated OBJ Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.104.4</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedOBJStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.104.4", "Encapsulated OBJ Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Encapsulated MTL Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.104.5</para>
        /// </summary>
        public static readonly DicomUid EncapsulatedMTLStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.104.5", "Encapsulated MTL Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Positron Emission Tomography Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.128</para>
        /// </summary>
        public static readonly DicomUid PositronEmissionTomographyImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.128", "Positron Emission Tomography Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Legacy Converted Enhanced PET Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.128.1</para>
        /// </summary>
        public static readonly DicomUid LegacyConvertedEnhancedPETImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.128.1", "Legacy Converted Enhanced PET Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Standalone PET Curve Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.129</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid StandalonePETCurveStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.129", "Standalone PET Curve Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced PET Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.130</para>
        /// </summary>
        public static readonly DicomUid EnhancedPETImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.130", "Enhanced PET Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Basic Structured Display Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.131</para>
        /// </summary>
        public static readonly DicomUid BasicStructuredDisplayStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.131", "Basic Structured Display Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: CT Defined Procedure Protocol Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.1</para>
        /// </summary>
        public static readonly DicomUid CTDefinedProcedureProtocolStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.200.1", "CT Defined Procedure Protocol Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: CT Performed Procedure Protocol Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.2</para>
        /// </summary>
        public static readonly DicomUid CTPerformedProcedureProtocolStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.200.2", "CT Performed Procedure Protocol Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Protocol Approval Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.3</para>
        /// </summary>
        public static readonly DicomUid ProtocolApprovalStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.200.3", "Protocol Approval Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Protocol Approval Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.4</para>
        /// </summary>
        public static readonly DicomUid ProtocolApprovalInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.1.1.200.4", "Protocol Approval Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Protocol Approval Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.5</para>
        /// </summary>
        public static readonly DicomUid ProtocolApprovalInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.1.1.200.5", "Protocol Approval Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Protocol Approval Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.6</para>
        /// </summary>
        public static readonly DicomUid ProtocolApprovalInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.1.1.200.6", "Protocol Approval Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: XA Defined Procedure Protocol Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.7</para>
        /// </summary>
        public static readonly DicomUid XADefinedProcedureProtocolStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.200.7", "XA Defined Procedure Protocol Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: XA Performed Procedure Protocol Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.200.8</para>
        /// </summary>
        public static readonly DicomUid XAPerformedProcedureProtocolStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.200.8", "XA Performed Procedure Protocol Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Inventory Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.1</para>
        /// </summary>
        public static readonly DicomUid InventoryStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.201.1", "Inventory Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Inventory - FIND</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.2</para>
        /// </summary>
        public static readonly DicomUid InventoryFind = new DicomUid("1.2.840.10008.5.1.4.1.1.201.2", "Inventory - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Inventory - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.3</para>
        /// </summary>
        public static readonly DicomUid InventoryMove = new DicomUid("1.2.840.10008.5.1.4.1.1.201.3", "Inventory - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Inventory - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.4</para>
        /// </summary>
        public static readonly DicomUid InventoryGet = new DicomUid("1.2.840.10008.5.1.4.1.1.201.4", "Inventory - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Inventory Creation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.5</para>
        /// </summary>
        public static readonly DicomUid InventoryCreation = new DicomUid("1.2.840.10008.5.1.4.1.1.201.5", "Inventory Creation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Repository Query</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.6</para>
        /// </summary>
        public static readonly DicomUid RepositoryQuery = new DicomUid("1.2.840.10008.5.1.4.1.1.201.6", "Repository Query", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: Storage Management SOP Instance</para>
        /// <para>1.2.840.10008.5.1.4.1.1.201.1.1</para>
        /// </summary>
        public static readonly DicomUid StorageManagementInstance = new DicomUid("1.2.840.10008.5.1.4.1.1.201.1.1", "Storage Management SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>SOP Class: RT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.1</para>
        /// </summary>
        public static readonly DicomUid RTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.1", "RT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Dose Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.2</para>
        /// </summary>
        public static readonly DicomUid RTDoseStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.2", "RT Dose Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Structure Set Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.3</para>
        /// </summary>
        public static readonly DicomUid RTStructureSetStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.3", "RT Structure Set Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Beams Treatment Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.4</para>
        /// </summary>
        public static readonly DicomUid RTBeamsTreatmentRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.4", "RT Beams Treatment Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Plan Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.5</para>
        /// </summary>
        public static readonly DicomUid RTPlanStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.5", "RT Plan Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Brachy Treatment Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.6</para>
        /// </summary>
        public static readonly DicomUid RTBrachyTreatmentRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.6", "RT Brachy Treatment Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Treatment Summary Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.7</para>
        /// </summary>
        public static readonly DicomUid RTTreatmentSummaryRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.7", "RT Treatment Summary Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Ion Plan Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.8</para>
        /// </summary>
        public static readonly DicomUid RTIonPlanStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.8", "RT Ion Plan Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Ion Beams Treatment Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.9</para>
        /// </summary>
        public static readonly DicomUid RTIonBeamsTreatmentRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.9", "RT Ion Beams Treatment Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Physician Intent Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.10</para>
        /// </summary>
        public static readonly DicomUid RTPhysicianIntentStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.10", "RT Physician Intent Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Segment Annotation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.11</para>
        /// </summary>
        public static readonly DicomUid RTSegmentAnnotationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.11", "RT Segment Annotation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Radiation Set Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.12</para>
        /// </summary>
        public static readonly DicomUid RTRadiationSetStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.12", "RT Radiation Set Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: C-Arm Photon-Electron Radiation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.13</para>
        /// </summary>
        public static readonly DicomUid CArmPhotonElectronRadiationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.13", "C-Arm Photon-Electron Radiation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Tomotherapeutic Radiation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.14</para>
        /// </summary>
        public static readonly DicomUid TomotherapeuticRadiationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.14", "Tomotherapeutic Radiation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Robotic-Arm Radiation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.15</para>
        /// </summary>
        public static readonly DicomUid RoboticArmRadiationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.15", "Robotic-Arm Radiation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Radiation Record Set Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.16</para>
        /// </summary>
        public static readonly DicomUid RTRadiationRecordSetStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.16", "RT Radiation Record Set Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Radiation Salvage Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.17</para>
        /// </summary>
        public static readonly DicomUid RTRadiationSalvageRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.17", "RT Radiation Salvage Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Tomotherapeutic Radiation Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.18</para>
        /// </summary>
        public static readonly DicomUid TomotherapeuticRadiationRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.18", "Tomotherapeutic Radiation Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: C-Arm Photon-Electron Radiation Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.19</para>
        /// </summary>
        public static readonly DicomUid CArmPhotonElectronRadiationRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.19", "C-Arm Photon-Electron Radiation Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Robotic Radiation Record Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.20</para>
        /// </summary>
        public static readonly DicomUid RoboticRadiationRecordStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.20", "Robotic Radiation Record Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Radiation Set Delivery Instruction Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.21</para>
        /// </summary>
        public static readonly DicomUid RTRadiationSetDeliveryInstructionStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.21", "RT Radiation Set Delivery Instruction Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Treatment Preparation Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.22</para>
        /// </summary>
        public static readonly DicomUid RTTreatmentPreparationStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.22", "RT Treatment Preparation Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced RT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.23</para>
        /// </summary>
        public static readonly DicomUid EnhancedRTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.23", "Enhanced RT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Enhanced Continuous RT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.24</para>
        /// </summary>
        public static readonly DicomUid EnhancedContinuousRTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.24", "Enhanced Continuous RT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Patient Position Acquisition Instruction Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.481.25</para>
        /// </summary>
        public static readonly DicomUid RTPatientPositionAcquisitionInstructionStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.481.25", "RT Patient Position Acquisition Instruction Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS CT Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.1</para>
        /// </summary>
        public static readonly DicomUid DICOSCTImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.501.1", "DICOS CT Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS Digital X-Ray Image Storage - For Presentation</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.2.1</para>
        /// </summary>
        public static readonly DicomUid DICOSDigitalXRayImageStorageForPresentation = new DicomUid("1.2.840.10008.5.1.4.1.1.501.2.1", "DICOS Digital X-Ray Image Storage - For Presentation", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS Digital X-Ray Image Storage - For Processing</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.2.2</para>
        /// </summary>
        public static readonly DicomUid DICOSDigitalXRayImageStorageForProcessing = new DicomUid("1.2.840.10008.5.1.4.1.1.501.2.2", "DICOS Digital X-Ray Image Storage - For Processing", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS Threat Detection Report Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.3</para>
        /// </summary>
        public static readonly DicomUid DICOSThreatDetectionReportStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.501.3", "DICOS Threat Detection Report Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS 2D AIT Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.4</para>
        /// </summary>
        public static readonly DicomUid DICOS2DAITStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.501.4", "DICOS 2D AIT Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS 3D AIT Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.5</para>
        /// </summary>
        public static readonly DicomUid DICOS3DAITStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.501.5", "DICOS 3D AIT Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: DICOS Quadrupole Resonance (QR) Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.501.6</para>
        /// </summary>
        public static readonly DicomUid DICOSQuadrupoleResonanceStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.501.6", "DICOS Quadrupole Resonance (QR) Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Eddy Current Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.601.1</para>
        /// </summary>
        public static readonly DicomUid EddyCurrentImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.601.1", "Eddy Current Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Eddy Current Multi-frame Image Storage</para>
        /// <para>1.2.840.10008.5.1.4.1.1.601.2</para>
        /// </summary>
        public static readonly DicomUid EddyCurrentMultiFrameImageStorage = new DicomUid("1.2.840.10008.5.1.4.1.1.601.2", "Eddy Current Multi-frame Image Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient Root Query/Retrieve Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.1.2.1.1</para>
        /// </summary>
        public static readonly DicomUid PatientRootQueryRetrieveInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.1.2.1.1", "Patient Root Query/Retrieve Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient Root Query/Retrieve Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.2.1.2</para>
        /// </summary>
        public static readonly DicomUid PatientRootQueryRetrieveInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.1.2.1.2", "Patient Root Query/Retrieve Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient Root Query/Retrieve Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.2.1.3</para>
        /// </summary>
        public static readonly DicomUid PatientRootQueryRetrieveInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.1.2.1.3", "Patient Root Query/Retrieve Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Study Root Query/Retrieve Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.1.2.2.1</para>
        /// </summary>
        public static readonly DicomUid StudyRootQueryRetrieveInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.1.2.2.1", "Study Root Query/Retrieve Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Study Root Query/Retrieve Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.2.2.2</para>
        /// </summary>
        public static readonly DicomUid StudyRootQueryRetrieveInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.1.2.2.2", "Study Root Query/Retrieve Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Study Root Query/Retrieve Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.2.2.3</para>
        /// </summary>
        public static readonly DicomUid StudyRootQueryRetrieveInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.1.2.2.3", "Study Root Query/Retrieve Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient/Study Only Query/Retrieve Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.1.2.3.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PatientStudyOnlyQueryRetrieveInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.1.2.3.1", "Patient/Study Only Query/Retrieve Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient/Study Only Query/Retrieve Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.2.3.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PatientStudyOnlyQueryRetrieveInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.1.2.3.2", "Patient/Study Only Query/Retrieve Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Patient/Study Only Query/Retrieve Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.2.3.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2004).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2004).")]
        public static readonly DicomUid PatientStudyOnlyQueryRetrieveInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.1.2.3.3", "Patient/Study Only Query/Retrieve Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Composite Instance Root Retrieve - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.1.2.4.2</para>
        /// </summary>
        public static readonly DicomUid CompositeInstanceRootRetrieveMove = new DicomUid("1.2.840.10008.5.1.4.1.2.4.2", "Composite Instance Root Retrieve - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Composite Instance Root Retrieve - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.2.4.3</para>
        /// </summary>
        public static readonly DicomUid CompositeInstanceRootRetrieveGet = new DicomUid("1.2.840.10008.5.1.4.1.2.4.3", "Composite Instance Root Retrieve - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Composite Instance Retrieve Without Bulk Data - GET</para>
        /// <para>1.2.840.10008.5.1.4.1.2.5.3</para>
        /// </summary>
        public static readonly DicomUid CompositeInstanceRetrieveWithoutBulkDataGet = new DicomUid("1.2.840.10008.5.1.4.1.2.5.3", "Composite Instance Retrieve Without Bulk Data - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Defined Procedure Protocol Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.20.1</para>
        /// </summary>
        public static readonly DicomUid DefinedProcedureProtocolInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.20.1", "Defined Procedure Protocol Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Defined Procedure Protocol Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.20.2</para>
        /// </summary>
        public static readonly DicomUid DefinedProcedureProtocolInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.20.2", "Defined Procedure Protocol Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Defined Procedure Protocol Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.20.3</para>
        /// </summary>
        public static readonly DicomUid DefinedProcedureProtocolInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.20.3", "Defined Procedure Protocol Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Modality Worklist Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.31</para>
        /// </summary>
        public static readonly DicomUid ModalityWorklistInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.31", "Modality Worklist Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>Meta SOP Class: General Purpose Worklist Management Meta SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.32</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2011).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2011).")]
        public static readonly DicomUid GeneralPurposeWorklistManagementMeta = new DicomUid("1.2.840.10008.5.1.4.32", "General Purpose Worklist Management Meta SOP Class", UidType.MetaSOPClass);
        /// <summary>
        /// <para>SOP Class: General Purpose Worklist Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.32.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2011).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2011).")]
        public static readonly DicomUid GeneralPurposeWorklistInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.32.1", "General Purpose Worklist Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General Purpose Scheduled Procedure Step SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.32.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2011).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2011).")]
        public static readonly DicomUid GeneralPurposeScheduledProcedureStep = new DicomUid("1.2.840.10008.5.1.4.32.2", "General Purpose Scheduled Procedure Step SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General Purpose Performed Procedure Step SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.32.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2011).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2011).")]
        public static readonly DicomUid GeneralPurposePerformedProcedureStep = new DicomUid("1.2.840.10008.5.1.4.32.3", "General Purpose Performed Procedure Step SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Instance Availability Notification SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.33</para>
        /// </summary>
        public static readonly DicomUid InstanceAvailabilityNotification = new DicomUid("1.2.840.10008.5.1.4.33", "Instance Availability Notification SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Beams Delivery Instruction Storage - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid RTBeamsDeliveryInstructionStorageTrial = new DicomUid("1.2.840.10008.5.1.4.34.1", "RT Beams Delivery Instruction Storage - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Conventional Machine Verification - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid RTConventionalMachineVerificationTrial = new DicomUid("1.2.840.10008.5.1.4.34.2", "RT Conventional Machine Verification - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Ion Machine Verification - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid RTIonMachineVerificationTrial = new DicomUid("1.2.840.10008.5.1.4.34.3", "RT Ion Machine Verification - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>Service Class: Unified Worklist and Procedure Step Service Class - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.4</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid UnifiedWorklistAndProcedureStepTrial = new DicomUid("1.2.840.10008.5.1.4.34.4", "Unified Worklist and Procedure Step Service Class - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Push SOP Class - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.4.1</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid UnifiedProcedureStepPushTrial = new DicomUid("1.2.840.10008.5.1.4.34.4.1", "Unified Procedure Step - Push SOP Class - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Watch SOP Class - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.4.2</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid UnifiedProcedureStepWatchTrial = new DicomUid("1.2.840.10008.5.1.4.34.4.2", "Unified Procedure Step - Watch SOP Class - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Pull SOP Class - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.4.3</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid UnifiedProcedureStepPullTrial = new DicomUid("1.2.840.10008.5.1.4.34.4.3", "Unified Procedure Step - Pull SOP Class - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Event SOP Class - Trial</para>
        /// <para>1.2.840.10008.5.1.4.34.4.4</para>
        /// <para>This UID has been retired. Refer to DICOM PS3 (2009).</para>
        /// </summary>
        [Obsolete("This UID has been retired. Refer to DICOM PS3 (2009).")]
        public static readonly DicomUid UnifiedProcedureStepEventTrial = new DicomUid("1.2.840.10008.5.1.4.34.4.4", "Unified Procedure Step - Event SOP Class - Trial", UidType.SOPClass);
        /// <summary>
        /// <para>Well-known SOP Instance: UPS Global Subscription SOP Instance</para>
        /// <para>1.2.840.10008.5.1.4.34.5</para>
        /// </summary>
        public static readonly DicomUid UPSGlobalSubscriptionInstance = new DicomUid("1.2.840.10008.5.1.4.34.5", "UPS Global Subscription SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Well-known SOP Instance: UPS Filtered Global Subscription SOP Instance</para>
        /// <para>1.2.840.10008.5.1.4.34.5.1</para>
        /// </summary>
        public static readonly DicomUid UPSFilteredGlobalSubscriptionInstance = new DicomUid("1.2.840.10008.5.1.4.34.5.1", "UPS Filtered Global Subscription SOP Instance", UidType.SOPInstance);
        /// <summary>
        /// <para>Service Class: Unified Worklist and Procedure Step Service Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6</para>
        /// </summary>
        public static readonly DicomUid UnifiedWorklistAndProcedureStep = new DicomUid("1.2.840.10008.5.1.4.34.6", "Unified Worklist and Procedure Step Service Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Push SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6.1</para>
        /// </summary>
        public static readonly DicomUid UnifiedProcedureStepPush = new DicomUid("1.2.840.10008.5.1.4.34.6.1", "Unified Procedure Step - Push SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Watch SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6.2</para>
        /// </summary>
        public static readonly DicomUid UnifiedProcedureStepWatch = new DicomUid("1.2.840.10008.5.1.4.34.6.2", "Unified Procedure Step - Watch SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Pull SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6.3</para>
        /// </summary>
        public static readonly DicomUid UnifiedProcedureStepPull = new DicomUid("1.2.840.10008.5.1.4.34.6.3", "Unified Procedure Step - Pull SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Event SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6.4</para>
        /// </summary>
        public static readonly DicomUid UnifiedProcedureStepEvent = new DicomUid("1.2.840.10008.5.1.4.34.6.4", "Unified Procedure Step - Event SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Unified Procedure Step - Query SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.34.6.5</para>
        /// </summary>
        public static readonly DicomUid UnifiedProcedureStepQuery = new DicomUid("1.2.840.10008.5.1.4.34.6.5", "Unified Procedure Step - Query SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Beams Delivery Instruction Storage</para>
        /// <para>1.2.840.10008.5.1.4.34.7</para>
        /// </summary>
        public static readonly DicomUid RTBeamsDeliveryInstructionStorage = new DicomUid("1.2.840.10008.5.1.4.34.7", "RT Beams Delivery Instruction Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Conventional Machine Verification</para>
        /// <para>1.2.840.10008.5.1.4.34.8</para>
        /// </summary>
        public static readonly DicomUid RTConventionalMachineVerification = new DicomUid("1.2.840.10008.5.1.4.34.8", "RT Conventional Machine Verification", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Ion Machine Verification</para>
        /// <para>1.2.840.10008.5.1.4.34.9</para>
        /// </summary>
        public static readonly DicomUid RTIonMachineVerification = new DicomUid("1.2.840.10008.5.1.4.34.9", "RT Ion Machine Verification", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: RT Brachy Application Setup Delivery Instruction Storage</para>
        /// <para>1.2.840.10008.5.1.4.34.10</para>
        /// </summary>
        public static readonly DicomUid RTBrachyApplicationSetupDeliveryInstructionStorage = new DicomUid("1.2.840.10008.5.1.4.34.10", "RT Brachy Application Setup Delivery Instruction Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: General Relevant Patient Information Query</para>
        /// <para>1.2.840.10008.5.1.4.37.1</para>
        /// </summary>
        public static readonly DicomUid GeneralRelevantPatientInformationQuery = new DicomUid("1.2.840.10008.5.1.4.37.1", "General Relevant Patient Information Query", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Breast Imaging Relevant Patient Information Query</para>
        /// <para>1.2.840.10008.5.1.4.37.2</para>
        /// </summary>
        public static readonly DicomUid BreastImagingRelevantPatientInformationQuery = new DicomUid("1.2.840.10008.5.1.4.37.2", "Breast Imaging Relevant Patient Information Query", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Cardiac Relevant Patient Information Query</para>
        /// <para>1.2.840.10008.5.1.4.37.3</para>
        /// </summary>
        public static readonly DicomUid CardiacRelevantPatientInformationQuery = new DicomUid("1.2.840.10008.5.1.4.37.3", "Cardiac Relevant Patient Information Query", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hanging Protocol Storage</para>
        /// <para>1.2.840.10008.5.1.4.38.1</para>
        /// </summary>
        public static readonly DicomUid HangingProtocolStorage = new DicomUid("1.2.840.10008.5.1.4.38.1", "Hanging Protocol Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hanging Protocol Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.38.2</para>
        /// </summary>
        public static readonly DicomUid HangingProtocolInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.38.2", "Hanging Protocol Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hanging Protocol Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.38.3</para>
        /// </summary>
        public static readonly DicomUid HangingProtocolInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.38.3", "Hanging Protocol Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Hanging Protocol Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.38.4</para>
        /// </summary>
        public static readonly DicomUid HangingProtocolInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.38.4", "Hanging Protocol Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Color Palette Storage</para>
        /// <para>1.2.840.10008.5.1.4.39.1</para>
        /// </summary>
        public static readonly DicomUid ColorPaletteStorage = new DicomUid("1.2.840.10008.5.1.4.39.1", "Color Palette Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Color Palette Query/Retrieve Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.39.2</para>
        /// </summary>
        public static readonly DicomUid ColorPaletteQueryRetrieveInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.39.2", "Color Palette Query/Retrieve Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Color Palette Query/Retrieve Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.39.3</para>
        /// </summary>
        public static readonly DicomUid ColorPaletteQueryRetrieveInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.39.3", "Color Palette Query/Retrieve Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Color Palette Query/Retrieve Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.39.4</para>
        /// </summary>
        public static readonly DicomUid ColorPaletteQueryRetrieveInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.39.4", "Color Palette Query/Retrieve Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Product Characteristics Query SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.41</para>
        /// </summary>
        public static readonly DicomUid ProductCharacteristicsQuery = new DicomUid("1.2.840.10008.5.1.4.41", "Product Characteristics Query SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Substance Approval Query SOP Class</para>
        /// <para>1.2.840.10008.5.1.4.42</para>
        /// </summary>
        public static readonly DicomUid SubstanceApprovalQuery = new DicomUid("1.2.840.10008.5.1.4.42", "Substance Approval Query SOP Class", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Generic Implant Template Storage</para>
        /// <para>1.2.840.10008.5.1.4.43.1</para>
        /// </summary>
        public static readonly DicomUid GenericImplantTemplateStorage = new DicomUid("1.2.840.10008.5.1.4.43.1", "Generic Implant Template Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Generic Implant Template Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.43.2</para>
        /// </summary>
        public static readonly DicomUid GenericImplantTemplateInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.43.2", "Generic Implant Template Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Generic Implant Template Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.43.3</para>
        /// </summary>
        public static readonly DicomUid GenericImplantTemplateInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.43.3", "Generic Implant Template Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Generic Implant Template Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.43.4</para>
        /// </summary>
        public static readonly DicomUid GenericImplantTemplateInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.43.4", "Generic Implant Template Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Assembly Template Storage</para>
        /// <para>1.2.840.10008.5.1.4.44.1</para>
        /// </summary>
        public static readonly DicomUid ImplantAssemblyTemplateStorage = new DicomUid("1.2.840.10008.5.1.4.44.1", "Implant Assembly Template Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Assembly Template Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.44.2</para>
        /// </summary>
        public static readonly DicomUid ImplantAssemblyTemplateInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.44.2", "Implant Assembly Template Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Assembly Template Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.44.3</para>
        /// </summary>
        public static readonly DicomUid ImplantAssemblyTemplateInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.44.3", "Implant Assembly Template Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Assembly Template Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.44.4</para>
        /// </summary>
        public static readonly DicomUid ImplantAssemblyTemplateInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.44.4", "Implant Assembly Template Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Template Group Storage</para>
        /// <para>1.2.840.10008.5.1.4.45.1</para>
        /// </summary>
        public static readonly DicomUid ImplantTemplateGroupStorage = new DicomUid("1.2.840.10008.5.1.4.45.1", "Implant Template Group Storage", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Template Group Information Model - FIND</para>
        /// <para>1.2.840.10008.5.1.4.45.2</para>
        /// </summary>
        public static readonly DicomUid ImplantTemplateGroupInformationModelFind = new DicomUid("1.2.840.10008.5.1.4.45.2", "Implant Template Group Information Model - FIND", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Template Group Information Model - MOVE</para>
        /// <para>1.2.840.10008.5.1.4.45.3</para>
        /// </summary>
        public static readonly DicomUid ImplantTemplateGroupInformationModelMove = new DicomUid("1.2.840.10008.5.1.4.45.3", "Implant Template Group Information Model - MOVE", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Implant Template Group Information Model - GET</para>
        /// <para>1.2.840.10008.5.1.4.45.4</para>
        /// </summary>
        public static readonly DicomUid ImplantTemplateGroupInformationModelGet = new DicomUid("1.2.840.10008.5.1.4.45.4", "Implant Template Group Information Model - GET", UidType.SOPClass);
        /// <summary>
        /// <para>Application Hosting Model: Native DICOM Model</para>
        /// <para>1.2.840.10008.7.1.1</para>
        /// </summary>
        public static readonly DicomUid NativeDICOMModel = new DicomUid("1.2.840.10008.7.1.1", "Native DICOM Model", UidType.ApplicationHostingModel);
        /// <summary>
        /// <para>Application Hosting Model: Abstract Multi-Dimensional Image Model</para>
        /// <para>1.2.840.10008.7.1.2</para>
        /// </summary>
        public static readonly DicomUid AbstractMultiDimensionalImageModel = new DicomUid("1.2.840.10008.7.1.2", "Abstract Multi-Dimensional Image Model", UidType.ApplicationHostingModel);
        /// <summary>
        /// <para>Mapping Resource: DICOM Content Mapping Resource</para>
        /// <para>1.2.840.10008.8.1.1</para>
        /// </summary>
        public static readonly DicomUid DICOMContentMappingResource = new DicomUid("1.2.840.10008.8.1.1", "DICOM Content Mapping Resource", UidType.MappingResource);
        /// <summary>
        /// <para>SOP Class: Video Endoscopic Image Real-Time Communication</para>
        /// <para>1.2.840.10008.10.1</para>
        /// </summary>
        public static readonly DicomUid VideoEndoscopicImageRealTimeCommunication = new DicomUid("1.2.840.10008.10.1", "Video Endoscopic Image Real-Time Communication", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Video Photographic Image Real-Time Communication</para>
        /// <para>1.2.840.10008.10.2</para>
        /// </summary>
        public static readonly DicomUid VideoPhotographicImageRealTimeCommunication = new DicomUid("1.2.840.10008.10.2", "Video Photographic Image Real-Time Communication", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Audio Waveform Real-Time Communication</para>
        /// <para>1.2.840.10008.10.3</para>
        /// </summary>
        public static readonly DicomUid AudioWaveformRealTimeCommunication = new DicomUid("1.2.840.10008.10.3", "Audio Waveform Real-Time Communication", UidType.SOPClass);
        /// <summary>
        /// <para>SOP Class: Rendition Selection Document Real-Time Communication</para>
        /// <para>1.2.840.10008.10.4</para>
        /// </summary>
        public static readonly DicomUid RenditionSelectionDocumentRealTimeCommunication = new DicomUid("1.2.840.10008.10.4", "Rendition Selection Document Real-Time Communication", UidType.SOPClass);
        /// <summary>
        /// <para>LDAP OID: dicom​Device​Name</para>
        /// <para>1.2.840.10008.15.0.3.1</para>
        /// </summary>
        public static readonly DicomUid dicomDeviceName = new DicomUid("1.2.840.10008.15.0.3.1", "dicom​Device​Name", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Description</para>
        /// <para>1.2.840.10008.15.0.3.2</para>
        /// </summary>
        public static readonly DicomUid dicomDescription = new DicomUid("1.2.840.10008.15.0.3.2", "dicom​Description", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Manufacturer</para>
        /// <para>1.2.840.10008.15.0.3.3</para>
        /// </summary>
        public static readonly DicomUid dicomManufacturer = new DicomUid("1.2.840.10008.15.0.3.3", "dicom​Manufacturer", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Manufacturer​Model​Name</para>
        /// <para>1.2.840.10008.15.0.3.4</para>
        /// </summary>
        public static readonly DicomUid dicomManufacturerModelName = new DicomUid("1.2.840.10008.15.0.3.4", "dicom​Manufacturer​Model​Name", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Software​Version</para>
        /// <para>1.2.840.10008.15.0.3.5</para>
        /// </summary>
        public static readonly DicomUid dicomSoftwareVersion = new DicomUid("1.2.840.10008.15.0.3.5", "dicom​Software​Version", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Vendor​Data</para>
        /// <para>1.2.840.10008.15.0.3.6</para>
        /// </summary>
        public static readonly DicomUid dicomVendorData = new DicomUid("1.2.840.10008.15.0.3.6", "dicom​Vendor​Data", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​AE​Title</para>
        /// <para>1.2.840.10008.15.0.3.7</para>
        /// </summary>
        public static readonly DicomUid dicomAETitle = new DicomUid("1.2.840.10008.15.0.3.7", "dicom​AE​Title", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Network​Connection​Reference</para>
        /// <para>1.2.840.10008.15.0.3.8</para>
        /// </summary>
        public static readonly DicomUid dicomNetworkConnectionReference = new DicomUid("1.2.840.10008.15.0.3.8", "dicom​Network​Connection​Reference", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Application​Cluster</para>
        /// <para>1.2.840.10008.15.0.3.9</para>
        /// </summary>
        public static readonly DicomUid dicomApplicationCluster = new DicomUid("1.2.840.10008.15.0.3.9", "dicom​Application​Cluster", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Association​Initiator</para>
        /// <para>1.2.840.10008.15.0.3.10</para>
        /// </summary>
        public static readonly DicomUid dicomAssociationInitiator = new DicomUid("1.2.840.10008.15.0.3.10", "dicom​Association​Initiator", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Association​Acceptor</para>
        /// <para>1.2.840.10008.15.0.3.11</para>
        /// </summary>
        public static readonly DicomUid dicomAssociationAcceptor = new DicomUid("1.2.840.10008.15.0.3.11", "dicom​Association​Acceptor", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Hostname</para>
        /// <para>1.2.840.10008.15.0.3.12</para>
        /// </summary>
        public static readonly DicomUid dicomHostname = new DicomUid("1.2.840.10008.15.0.3.12", "dicom​Hostname", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Port</para>
        /// <para>1.2.840.10008.15.0.3.13</para>
        /// </summary>
        public static readonly DicomUid dicomPort = new DicomUid("1.2.840.10008.15.0.3.13", "dicom​Port", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​SOP​Class</para>
        /// <para>1.2.840.10008.15.0.3.14</para>
        /// </summary>
        public static readonly DicomUid dicomSOPClass = new DicomUid("1.2.840.10008.15.0.3.14", "dicom​SOP​Class", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Transfer​Role</para>
        /// <para>1.2.840.10008.15.0.3.15</para>
        /// </summary>
        public static readonly DicomUid dicomTransferRole = new DicomUid("1.2.840.10008.15.0.3.15", "dicom​Transfer​Role", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Transfer​Syntax</para>
        /// <para>1.2.840.10008.15.0.3.16</para>
        /// </summary>
        public static readonly DicomUid dicomTransferSyntax = new DicomUid("1.2.840.10008.15.0.3.16", "dicom​Transfer​Syntax", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Primary​Device​Type</para>
        /// <para>1.2.840.10008.15.0.3.17</para>
        /// </summary>
        public static readonly DicomUid dicomPrimaryDeviceType = new DicomUid("1.2.840.10008.15.0.3.17", "dicom​Primary​Device​Type", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Related​Device​Reference</para>
        /// <para>1.2.840.10008.15.0.3.18</para>
        /// </summary>
        public static readonly DicomUid dicomRelatedDeviceReference = new DicomUid("1.2.840.10008.15.0.3.18", "dicom​Related​Device​Reference", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Preferred​Called​AE​Title</para>
        /// <para>1.2.840.10008.15.0.3.19</para>
        /// </summary>
        public static readonly DicomUid dicomPreferredCalledAETitle = new DicomUid("1.2.840.10008.15.0.3.19", "dicom​Preferred​Called​AE​Title", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​TLS​Cyphersuite</para>
        /// <para>1.2.840.10008.15.0.3.20</para>
        /// </summary>
        public static readonly DicomUid dicomTLSCyphersuite = new DicomUid("1.2.840.10008.15.0.3.20", "dicom​TLS​Cyphersuite", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Authorized​Node​Certificate​Reference</para>
        /// <para>1.2.840.10008.15.0.3.21</para>
        /// </summary>
        public static readonly DicomUid dicomAuthorizedNodeCertificateReference = new DicomUid("1.2.840.10008.15.0.3.21", "dicom​Authorized​Node​Certificate​Reference", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​This​Node​Certificate​Reference</para>
        /// <para>1.2.840.10008.15.0.3.22</para>
        /// </summary>
        public static readonly DicomUid dicomThisNodeCertificateReference = new DicomUid("1.2.840.10008.15.0.3.22", "dicom​This​Node​Certificate​Reference", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Installed</para>
        /// <para>1.2.840.10008.15.0.3.23</para>
        /// </summary>
        public static readonly DicomUid dicomInstalled = new DicomUid("1.2.840.10008.15.0.3.23", "dicom​Installed", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Station​Name</para>
        /// <para>1.2.840.10008.15.0.3.24</para>
        /// </summary>
        public static readonly DicomUid dicomStationName = new DicomUid("1.2.840.10008.15.0.3.24", "dicom​Station​Name", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Device​Serial​Number</para>
        /// <para>1.2.840.10008.15.0.3.25</para>
        /// </summary>
        public static readonly DicomUid dicomDeviceSerialNumber = new DicomUid("1.2.840.10008.15.0.3.25", "dicom​Device​Serial​Number", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Institution​Name</para>
        /// <para>1.2.840.10008.15.0.3.26</para>
        /// </summary>
        public static readonly DicomUid dicomInstitutionName = new DicomUid("1.2.840.10008.15.0.3.26", "dicom​Institution​Name", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Institution​Address</para>
        /// <para>1.2.840.10008.15.0.3.27</para>
        /// </summary>
        public static readonly DicomUid dicomInstitutionAddress = new DicomUid("1.2.840.10008.15.0.3.27", "dicom​Institution​Address", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Institution​Department​Name</para>
        /// <para>1.2.840.10008.15.0.3.28</para>
        /// </summary>
        public static readonly DicomUid dicomInstitutionDepartmentName = new DicomUid("1.2.840.10008.15.0.3.28", "dicom​Institution​Department​Name", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Issuer​Of​Patient​ID</para>
        /// <para>1.2.840.10008.15.0.3.29</para>
        /// </summary>
        public static readonly DicomUid dicomIssuerOfPatientID = new DicomUid("1.2.840.10008.15.0.3.29", "dicom​Issuer​Of​Patient​ID", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Preferred​Calling​AE​Title</para>
        /// <para>1.2.840.10008.15.0.3.30</para>
        /// </summary>
        public static readonly DicomUid dicomPreferredCallingAETitle = new DicomUid("1.2.840.10008.15.0.3.30", "dicom​Preferred​Calling​AE​Title", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Supported​Character​Set</para>
        /// <para>1.2.840.10008.15.0.3.31</para>
        /// </summary>
        public static readonly DicomUid dicomSupportedCharacterSet = new DicomUid("1.2.840.10008.15.0.3.31", "dicom​Supported​Character​Set", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Configuration​Root</para>
        /// <para>1.2.840.10008.15.0.4.1</para>
        /// </summary>
        public static readonly DicomUid dicomConfigurationRoot = new DicomUid("1.2.840.10008.15.0.4.1", "dicom​Configuration​Root", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Devices​Root</para>
        /// <para>1.2.840.10008.15.0.4.2</para>
        /// </summary>
        public static readonly DicomUid dicomDevicesRoot = new DicomUid("1.2.840.10008.15.0.4.2", "dicom​Devices​Root", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Unique​AE​Titles​Registry​Root</para>
        /// <para>1.2.840.10008.15.0.4.3</para>
        /// </summary>
        public static readonly DicomUid dicomUniqueAETitlesRegistryRoot = new DicomUid("1.2.840.10008.15.0.4.3", "dicom​Unique​AE​Titles​Registry​Root", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Device</para>
        /// <para>1.2.840.10008.15.0.4.4</para>
        /// </summary>
        public static readonly DicomUid dicomDevice = new DicomUid("1.2.840.10008.15.0.4.4", "dicom​Device", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Network​AE</para>
        /// <para>1.2.840.10008.15.0.4.5</para>
        /// </summary>
        public static readonly DicomUid dicomNetworkAE = new DicomUid("1.2.840.10008.15.0.4.5", "dicom​Network​AE", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Network​Connection</para>
        /// <para>1.2.840.10008.15.0.4.6</para>
        /// </summary>
        public static readonly DicomUid dicomNetworkConnection = new DicomUid("1.2.840.10008.15.0.4.6", "dicom​Network​Connection", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Unique​AE​Title</para>
        /// <para>1.2.840.10008.15.0.4.7</para>
        /// </summary>
        public static readonly DicomUid dicomUniqueAETitle = new DicomUid("1.2.840.10008.15.0.4.7", "dicom​Unique​AE​Title", UidType.LdapOid);
        /// <summary>
        /// <para>LDAP OID: dicom​Transfer​Capability</para>
        /// <para>1.2.840.10008.15.0.4.8</para>
        /// </summary>
        public static readonly DicomUid dicomTransferCapability = new DicomUid("1.2.840.10008.15.0.4.8", "dicom​Transfer​Capability", UidType.LdapOid);
        /// <summary>
        /// <para>Synchronization Frame of Reference: Universal Coordinated Time</para>
        /// <para>1.2.840.10008.15.1.1</para>
        /// </summary>
        public static readonly DicomUid UTC = new DicomUid("1.2.840.10008.15.1.1", "Universal Coordinated Time", UidType.SynchronizationFrameOfReference);
    }
}
