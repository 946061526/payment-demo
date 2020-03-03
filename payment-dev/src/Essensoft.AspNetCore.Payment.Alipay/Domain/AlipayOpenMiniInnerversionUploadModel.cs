﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// IDE开发打包类型
        /// </summary>
        [JsonPropertyName("build_app_type")]
        public string BuildAppType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// js api 权限文件
        /// </summary>
        [JsonPropertyName("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 主入口
        /// </summary>
        [JsonPropertyName("build_main_url")]
        public string BuildMainUrl { get; set; }

        /// <summary>
        /// 最大Android客户端版本号
        /// </summary>
        [JsonPropertyName("build_max_android_client_version")]
        public string BuildMaxAndroidClientVersion { get; set; }

        /// <summary>
        /// 最大iOS客户单版本号
        /// </summary>
        [JsonPropertyName("build_max_ios_client_version")]
        public string BuildMaxIosClientVersion { get; set; }

        /// <summary>
        /// 最小Android客户端版本号
        /// </summary>
        [JsonPropertyName("build_min_android_client_version")]
        public string BuildMinAndroidClientVersion { get; set; }

        /// <summary>
        /// 最小iOS客户单版本号
        /// </summary>
        [JsonPropertyName("build_min_ios_client_version")]
        public string BuildMinIosClientVersion { get; set; }

        /// <summary>
        /// 源码包MD5
        /// </summary>
        [JsonPropertyName("build_package_md_5")]
        public string BuildPackageMd5 { get; set; }

        /// <summary>
        /// 包名称
        /// </summary>
        [JsonPropertyName("build_package_name")]
        public string BuildPackageName { get; set; }

        /// <summary>
        /// 小程序源码包
        /// </summary>
        [JsonPropertyName("build_package_stream")]
        public string BuildPackageStream { get; set; }

        /// <summary>
        /// 打包平台扩展信息
        /// </summary>
        [JsonPropertyName("build_qcloud_info")]
        public string BuildQcloudInfo { get; set; }

        /// <summary>
        /// 源码包大小
        /// </summary>
        [JsonPropertyName("build_source_pkg_size")]
        public string BuildSourcePkgSize { get; set; }

        /// <summary>
        /// 源码包地址
        /// </summary>
        [JsonPropertyName("build_source_pkg_url")]
        public string BuildSourcePkgUrl { get; set; }

        /// <summary>
        /// 子入口
        /// </summary>
        [JsonPropertyName("build_sub_url")]
        public string BuildSubUrl { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 多端类型
        /// </summary>
        [JsonPropertyName("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型。
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息
        /// </summary>
        [JsonPropertyName("plugin_refs")]
        public List<MiniAppPluginReference> PluginRefs { get; set; }
    }
}
