// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: localization_status.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.localization
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MsfSensorMsgStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MsfSensorMsgStatus()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(ImuMsgDelayStatus.IMU_DELAY_NORMAL)]
        public ImuMsgDelayStatus imu_delay_status
        {
            get { return __pbn__imu_delay_status ?? ImuMsgDelayStatus.IMU_DELAY_NORMAL; }
            set { __pbn__imu_delay_status = value; }
        }
        public bool ShouldSerializeimu_delay_status()
        {
            return __pbn__imu_delay_status != null;
        }
        public void Resetimu_delay_status()
        {
            __pbn__imu_delay_status = null;
        }
        private ImuMsgDelayStatus? __pbn__imu_delay_status;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(ImuMsgMissingStatus.IMU_MISSING_NORMAL)]
        public ImuMsgMissingStatus imu_missing_status
        {
            get { return __pbn__imu_missing_status ?? ImuMsgMissingStatus.IMU_MISSING_NORMAL; }
            set { __pbn__imu_missing_status = value; }
        }
        public bool ShouldSerializeimu_missing_status()
        {
            return __pbn__imu_missing_status != null;
        }
        public void Resetimu_missing_status()
        {
            __pbn__imu_missing_status = null;
        }
        private ImuMsgMissingStatus? __pbn__imu_missing_status;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(ImuMsgDataStatus.IMU_DATA_NORMAL)]
        public ImuMsgDataStatus imu_data_status
        {
            get { return __pbn__imu_data_status ?? ImuMsgDataStatus.IMU_DATA_NORMAL; }
            set { __pbn__imu_data_status = value; }
        }
        public bool ShouldSerializeimu_data_status()
        {
            return __pbn__imu_data_status != null;
        }
        public void Resetimu_data_status()
        {
            __pbn__imu_data_status = null;
        }
        private ImuMsgDataStatus? __pbn__imu_data_status;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsfStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MsfStatus()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(LocalLidarConsistency.MSF_LOCAL_LIDAR_CONSISTENCY_00)]
        public LocalLidarConsistency local_lidar_consistency
        {
            get { return __pbn__local_lidar_consistency ?? LocalLidarConsistency.MSF_LOCAL_LIDAR_CONSISTENCY_00; }
            set { __pbn__local_lidar_consistency = value; }
        }
        public bool ShouldSerializelocal_lidar_consistency()
        {
            return __pbn__local_lidar_consistency != null;
        }
        public void Resetlocal_lidar_consistency()
        {
            __pbn__local_lidar_consistency = null;
        }
        private LocalLidarConsistency? __pbn__local_lidar_consistency;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(GnssConsistency.MSF_GNSS_CONSISTENCY_00)]
        public GnssConsistency gnss_consistency
        {
            get { return __pbn__gnss_consistency ?? GnssConsistency.MSF_GNSS_CONSISTENCY_00; }
            set { __pbn__gnss_consistency = value; }
        }
        public bool ShouldSerializegnss_consistency()
        {
            return __pbn__gnss_consistency != null;
        }
        public void Resetgnss_consistency()
        {
            __pbn__gnss_consistency = null;
        }
        private GnssConsistency? __pbn__gnss_consistency;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(LocalLidarStatus.MSF_LOCAL_LIDAR_NORMAL)]
        public LocalLidarStatus local_lidar_status
        {
            get { return __pbn__local_lidar_status ?? LocalLidarStatus.MSF_LOCAL_LIDAR_NORMAL; }
            set { __pbn__local_lidar_status = value; }
        }
        public bool ShouldSerializelocal_lidar_status()
        {
            return __pbn__local_lidar_status != null;
        }
        public void Resetlocal_lidar_status()
        {
            __pbn__local_lidar_status = null;
        }
        private LocalLidarStatus? __pbn__local_lidar_status;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(LocalLidarQuality.MSF_LOCAL_LIDAR_VERY_GOOD)]
        public LocalLidarQuality local_lidar_quality
        {
            get { return __pbn__local_lidar_quality ?? LocalLidarQuality.MSF_LOCAL_LIDAR_VERY_GOOD; }
            set { __pbn__local_lidar_quality = value; }
        }
        public bool ShouldSerializelocal_lidar_quality()
        {
            return __pbn__local_lidar_quality != null;
        }
        public void Resetlocal_lidar_quality()
        {
            __pbn__local_lidar_quality = null;
        }
        private LocalLidarQuality? __pbn__local_lidar_quality;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(GnssPositionType.NONE)]
        public GnssPositionType gnsspos_position_type
        {
            get { return __pbn__gnsspos_position_type ?? GnssPositionType.NONE; }
            set { __pbn__gnsspos_position_type = value; }
        }
        public bool ShouldSerializegnsspos_position_type()
        {
            return __pbn__gnsspos_position_type != null;
        }
        public void Resetgnsspos_position_type()
        {
            __pbn__gnsspos_position_type = null;
        }
        private GnssPositionType? __pbn__gnsspos_position_type;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(MsfRunningStatus.MSF_SOL_LIDAR_GNSS)]
        public MsfRunningStatus msf_running_status
        {
            get { return __pbn__msf_running_status ?? MsfRunningStatus.MSF_SOL_LIDAR_GNSS; }
            set { __pbn__msf_running_status = value; }
        }
        public bool ShouldSerializemsf_running_status()
        {
            return __pbn__msf_running_status != null;
        }
        public void Resetmsf_running_status()
        {
            __pbn__msf_running_status = null;
        }
        private MsfRunningStatus? __pbn__msf_running_status;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum LocalLidarStatus
    {
        MSF_LOCAL_LIDAR_NORMAL = 0,
        MSF_LOCAL_LIDAR_MAP_MISSING = 1,
        MSF_LOCAL_LIDAR_EXTRINSICS_MISSING = 2,
        MSF_LOCAL_LIDAR_MAP_LOADING_FAILED = 3,
        MSF_LOCAL_LIDAR_NO_OUTPUT = 4,
        MSF_LOCAL_LIDAR_OUT_OF_MAP = 5,
        MSF_LOCAL_LIDAR_NOT_GOOD = 6,
        MSF_LOCAL_LIDAR_UNDEFINED_STATUS = 7,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum LocalLidarQuality
    {
        MSF_LOCAL_LIDAR_VERY_GOOD = 0,
        MSF_LOCAL_LIDAR_GOOD = 1,
        MSF_LOCAL_LIDAR_NOT_BAD = 2,
        MSF_LOCAL_LIDAR_BAD = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum LocalLidarConsistency
    {
        MSF_LOCAL_LIDAR_CONSISTENCY_00 = 0,
        MSF_LOCAL_LIDAR_CONSISTENCY_01 = 1,
        MSF_LOCAL_LIDAR_CONSISTENCY_02 = 2,
        MSF_LOCAL_LIDAR_CONSISTENCY_03 = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum GnssConsistency
    {
        MSF_GNSS_CONSISTENCY_00 = 0,
        MSF_GNSS_CONSISTENCY_01 = 1,
        MSF_GNSS_CONSISTENCY_02 = 2,
        MSF_GNSS_CONSISTENCY_03 = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum GnssPositionType
    {
        NONE = 0,
        FIXEDPOS = 1,
        FIXEDHEIGHT = 2,
        FLOATCONV = 4,
        WIDELANE = 5,
        NARROWLANE = 6,
        DOPPLER_VELOCITY = 8,
        SINGLE = 16,
        PSRDIFF = 17,
        WAAS = 18,
        PROPOGATED = 19,
        OMNISTAR = 20,
        L1_FLOAT = 32,
        IONOFREE_FLOAT = 33,
        NARROW_FLOAT = 34,
        L1_INT = 48,
        WIDE_INT = 49,
        NARROW_INT = 50,
        RTK_DIRECT_INS = 51,
        INS_SBAS = 52,
        INS_PSRSP = 53,
        INS_PSRDIFF = 54,
        INS_RTKFLOAT = 55,
        INS_RTKFIXED = 56,
        INS_OMNISTAR = 57,
        INS_OMNISTAR_HP = 58,
        INS_OMNISTAR_XP = 59,
        OMNISTAR_HP = 64,
        OMNISTAR_XP = 65,
        PPP_CONVERGING = 68,
        PPP = 69,
        INS_PPP_Converging = 73,
        INS_PPP = 74,
        MSG_LOSS = 91,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ImuMsgDelayStatus
    {
        IMU_DELAY_NORMAL = 0,
        IMU_DELAY_1 = 1,
        IMU_DELAY_2 = 2,
        IMU_DELAY_3 = 3,
        IMU_DELAY_ABNORMAL = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ImuMsgMissingStatus
    {
        IMU_MISSING_NORMAL = 0,
        IMU_MISSING_1 = 1,
        IMU_MISSING_2 = 2,
        IMU_MISSING_3 = 3,
        IMU_MISSING_4 = 4,
        IMU_MISSING_5 = 5,
        IMU_MISSING_ABNORMAL = 6,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ImuMsgDataStatus
    {
        IMU_DATA_NORMAL = 0,
        IMU_DATA_ABNORMAL = 1,
        IMU_DATA_OTHER = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum MsfRunningStatus
    {
        MSF_SOL_LIDAR_GNSS = 0,
        MSF_SOL_X_GNSS = 1,
        MSF_SOL_LIDAR_X = 2,
        MSF_SOL_LIDAR_XX = 3,
        MSF_SOL_LIDAR_XXX = 4,
        MSF_SOL_X_X = 5,
        MSF_SOL_X_XX = 6,
        MSF_SOL_X_XXX = 7,
        MSF_SSOL_LIDAR_GNSS = 8,
        MSF_SSOL_X_GNSS = 9,
        MSF_SSOL_LIDAR_X = 10,
        MSF_SSOL_LIDAR_XX = 11,
        MSF_SSOL_LIDAR_XXX = 12,
        MSF_SSOL_X_X = 13,
        MSF_SSOL_X_XX = 14,
        MSF_SSOL_X_XXX = 15,
        MSF_NOSOL_LIDAR_GNSS = 16,
        MSF_NOSOL_X_GNSS = 17,
        MSF_NOSOL_LIDAR_X = 18,
        MSF_NOSOL_LIDAR_XX = 19,
        MSF_NOSOL_LIDAR_XXX = 20,
        MSF_NOSOL_X_X = 21,
        MSF_NOSOL_X_XX = 22,
        MSF_NOSOL_X_XXX = 23,
        MSF_RUNNING_INIT = 24,
    }

}

#pragma warning restore 0612, 1591, 3021