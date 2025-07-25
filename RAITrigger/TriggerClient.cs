﻿namespace Trigger
{

    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) :
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) :
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
            m.WriteInt16(Member28);
            m.Write_1(Member2C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
            Member28 = u.ReadInt16();
            Member2C = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public int Member20;
        public int Member24;
        public short Member28;
        public Struct_1 Member2C;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(string Member0, int Member8, int MemberC, int Member10, int Member14, int Member18, int Member1C, int Member20, int Member24, short Member28, Struct_1 Member2C)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member2C = Member2C;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt3264(Member0);
            m.WriteUInt3264(Member8);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadUInt3264();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8;
        public int Member10;
        public int Member14;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() :
                base("201ef99a-7fa0-444c-9399-19ba84f12a1a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int RAiLaunchAdminProcess(string p0, string p1, int p2, int p3, string p4, string p5, Struct_0 p6, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p7, int p8, out Struct_2 p9, out int p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.Write_0(p6);
            m.WriteUInt3264(p7);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(0, m);
            p9 = u.Read_2();
            p10 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RAiProcessRunOnce(string p0, out Struct_2 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.Read_2();
            return u.ReadInt32();
        }
        // async
        public int RAiLogonWithSmartCardCreds(int p0, string p1, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteUInt3264(p2);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int RAiOverrideDesktopPromptPolicy()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int RAiDisableElevationForSession(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int RAiEnableElevationForSession(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        // async
        public int RAiForceElevationPromptForCOM(NtApiDotNet.Ndr.Marshal.NdrUInt3264 p0, int p1, int p2, int p3, string p4, System.Guid p5, string p6, string p7, string p8, string p9, int p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteUInt3264(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteGuid(p5);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p8, "p8"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p9, "p9"));
            m.WriteInt32(p10);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
    }
    #endregion
}