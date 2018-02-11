using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     PodSecurityContext holds pod-level security attributes and common container settings. Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.
    /// </summary>
    [KubeResource("PodSecurityContext", "v1")]
    public class PodSecurityContextV1
    {
        /// <summary>
        ///     A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:
        ///     
        ///     1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----
        ///     
        ///     If unset, the Kubelet will not modify the ownership and permissions of any volume.
        /// </summary>
        [JsonProperty("fsGroup")]
        public int FsGroup { get; set; }

        /// <summary>
        ///     The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.
        /// </summary>
        [JsonProperty("runAsUser")]
        public int RunAsUser { get; set; }

        /// <summary>
        ///     The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.
        /// </summary>
        [JsonProperty("seLinuxOptions")]
        public SELinuxOptionsV1 SeLinuxOptions { get; set; }

        /// <summary>
        ///     A list of groups applied to the first process run in each container, in addition to the container's primary GID.  If unspecified, no groups will be added to any container.
        /// </summary>
        [JsonProperty("supplementalGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SupplementalGroups { get; set; } = new List<int>();

        /// <summary>
        ///     Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [JsonProperty("runAsNonRoot")]
        public bool RunAsNonRoot { get; set; }
    }
}
