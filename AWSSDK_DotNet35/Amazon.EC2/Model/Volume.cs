/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Represents an Amazon <i>Elastic Block Storage</i> (EBS) volume. </para>
    /// </summary>
    public class Volume
    {
        
        private string volumeId;
        private int? size;
        private string snapshotId;
        private string availabilityZone;
        private VolumeState state;
        private DateTime? createTime;
        private List<VolumeAttachment> attachments = new List<VolumeAttachment>();
        private List<Tag> tags = new List<Tag>();
        private VolumeType volumeType;
        private int? iops;


        /// <summary>
        /// The unique ID of this volume.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// The size of this volume, in gigabytes.
        ///  
        /// </summary>
        public int Size
        {
            get { return this.size ?? default(int); }
            set { this.size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }

        /// <summary>
        /// Optional snapshot from which this volume was created.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// Availability zone in which this volume was created.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// State of this volume (e.g., creating, available).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>creating, available, in-use, deleting, deleted, error</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VolumeState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Timestamp when volume creation was initiated.
        ///  
        /// </summary>
        public DateTime CreateTime
        {
            get { return this.createTime ?? default(DateTime); }
            set { this.createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this.createTime.HasValue;
        }

        /// <summary>
        /// Information on what this volume is attached to.
        ///  
        /// </summary>
        public List<VolumeAttachment> Attachments
        {
            get { return this.attachments; }
            set { this.attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this.attachments.Count > 0;
        }

        /// <summary>
        /// A list of tags for the Volume.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
        public VolumeType VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;
        }
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }
    }
}
