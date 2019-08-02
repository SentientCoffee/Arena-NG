using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0.15,0.15,0.15]")]
	public partial class PlayerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 3;

		private byte[] _dirtyFields = new byte[1];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		[ForgeGeneratedField]
		private Vector3 _position;
		public event FieldEvent<Vector3> positionChanged;
		public InterpolateVector3 positionInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 position
		{
			get { return _position; }
			set
			{
				// Don't do anything if the value is the same
				if (_position == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_position = value;
				hasDirtyFields = true;
			}
		}

		public void SetpositionDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_position(ulong timestep)
		{
			if (positionChanged != null) positionChanged(_position, timestep);
			if (fieldAltered != null) fieldAltered("position", _position, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _rotation;
		public event FieldEvent<Quaternion> rotationChanged;
		public InterpolateQuaternion rotationInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion rotation
		{
			get { return _rotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_rotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_rotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetrotationDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_rotation(ulong timestep)
		{
			if (rotationChanged != null) rotationChanged(_rotation, timestep);
			if (fieldAltered != null) fieldAltered("rotation", _rotation, timestep);
		}
		[ForgeGeneratedField]
		private Vector2 _animMoveVector;
		public event FieldEvent<Vector2> animMoveVectorChanged;
		public InterpolateVector2 animMoveVectorInterpolation = new InterpolateVector2() { LerpT = 0.15f, Enabled = true };
		public Vector2 animMoveVector
		{
			get { return _animMoveVector; }
			set
			{
				// Don't do anything if the value is the same
				if (_animMoveVector == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_animMoveVector = value;
				hasDirtyFields = true;
			}
		}

		public void SetanimMoveVectorDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_animMoveVector(ulong timestep)
		{
			if (animMoveVectorChanged != null) animMoveVectorChanged(_animMoveVector, timestep);
			if (fieldAltered != null) fieldAltered("animMoveVector", _animMoveVector, timestep);
		}
		[ForgeGeneratedField]
		private float _animLookPitch;
		public event FieldEvent<float> animLookPitchChanged;
		public InterpolateFloat animLookPitchInterpolation = new InterpolateFloat() { LerpT = 0.15f, Enabled = true };
		public float animLookPitch
		{
			get { return _animLookPitch; }
			set
			{
				// Don't do anything if the value is the same
				if (_animLookPitch == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_animLookPitch = value;
				hasDirtyFields = true;
			}
		}

		public void SetanimLookPitchDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_animLookPitch(ulong timestep)
		{
			if (animLookPitchChanged != null) animLookPitchChanged(_animLookPitch, timestep);
			if (fieldAltered != null) fieldAltered("animLookPitch", _animLookPitch, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			positionInterpolation.current = positionInterpolation.target;
			rotationInterpolation.current = rotationInterpolation.target;
			animMoveVectorInterpolation.current = animMoveVectorInterpolation.target;
			animLookPitchInterpolation.current = animLookPitchInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _position);
			UnityObjectMapper.Instance.MapBytes(data, _rotation);
			UnityObjectMapper.Instance.MapBytes(data, _animMoveVector);
			UnityObjectMapper.Instance.MapBytes(data, _animLookPitch);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_position = UnityObjectMapper.Instance.Map<Vector3>(payload);
			positionInterpolation.current = _position;
			positionInterpolation.target = _position;
			RunChange_position(timestep);
			_rotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			rotationInterpolation.current = _rotation;
			rotationInterpolation.target = _rotation;
			RunChange_rotation(timestep);
			_animMoveVector = UnityObjectMapper.Instance.Map<Vector2>(payload);
			animMoveVectorInterpolation.current = _animMoveVector;
			animMoveVectorInterpolation.target = _animMoveVector;
			RunChange_animMoveVector(timestep);
			_animLookPitch = UnityObjectMapper.Instance.Map<float>(payload);
			animLookPitchInterpolation.current = _animLookPitch;
			animLookPitchInterpolation.target = _animLookPitch;
			RunChange_animLookPitch(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _position);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rotation);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _animMoveVector);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _animLookPitch);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (positionInterpolation.Enabled)
				{
					positionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					positionInterpolation.Timestep = timestep;
				}
				else
				{
					_position = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_position(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (rotationInterpolation.Enabled)
				{
					rotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					rotationInterpolation.Timestep = timestep;
				}
				else
				{
					_rotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_rotation(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (animMoveVectorInterpolation.Enabled)
				{
					animMoveVectorInterpolation.target = UnityObjectMapper.Instance.Map<Vector2>(data);
					animMoveVectorInterpolation.Timestep = timestep;
				}
				else
				{
					_animMoveVector = UnityObjectMapper.Instance.Map<Vector2>(data);
					RunChange_animMoveVector(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (animLookPitchInterpolation.Enabled)
				{
					animLookPitchInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					animLookPitchInterpolation.Timestep = timestep;
				}
				else
				{
					_animLookPitch = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_animLookPitch(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (positionInterpolation.Enabled && !positionInterpolation.current.UnityNear(positionInterpolation.target, 0.0015f))
			{
				_position = (Vector3)positionInterpolation.Interpolate();
				//RunChange_position(positionInterpolation.Timestep);
			}
			if (rotationInterpolation.Enabled && !rotationInterpolation.current.UnityNear(rotationInterpolation.target, 0.0015f))
			{
				_rotation = (Quaternion)rotationInterpolation.Interpolate();
				//RunChange_rotation(rotationInterpolation.Timestep);
			}
			if (animMoveVectorInterpolation.Enabled && !animMoveVectorInterpolation.current.UnityNear(animMoveVectorInterpolation.target, 0.0015f))
			{
				_animMoveVector = (Vector2)animMoveVectorInterpolation.Interpolate();
				//RunChange_animMoveVector(animMoveVectorInterpolation.Timestep);
			}
			if (animLookPitchInterpolation.Enabled && !animLookPitchInterpolation.current.UnityNear(animLookPitchInterpolation.target, 0.0015f))
			{
				_animLookPitch = (float)animLookPitchInterpolation.Interpolate();
				//RunChange_animLookPitch(animLookPitchInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[1];

		}

		public PlayerNetworkObject() : base() { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
