// GENERATED AUTOMATICALLY FROM 'Assets/ArenaNG/Controls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controls : IInputActionCollection
{
    private InputActionAsset asset;
    public Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4e423518-f174-4c77-8650-cc1652d6499d"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""99ed181a-6485-40c1-8b74-c763fe52196b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6da39aea-fbeb-49c0-8c10-0fde37adad08"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fbc09274-522a-4438-8067-fe2e9c0078c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""021e1974-b26a-454f-8475-669ad3b69694"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""997f7998-57c3-48fb-a9d7-d0e80539c92c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Fire"",
                    ""type"": ""Button"",
                    ""id"": ""8bcd60f3-8b20-4aa1-9849-42d179bd13f5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Fire"",
                    ""type"": ""Button"",
                    ""id"": ""592369c9-651a-473c-b3a2-f9774cce9532"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""952bc487-ee12-497a-8a7f-267434b350ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Context Use"",
                    ""type"": ""Button"",
                    ""id"": ""d2e21138-298c-463e-9618-086ca71451a7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Slot Switch"",
                    ""type"": ""Value"",
                    ""id"": ""38133fd4-7197-4af9-bb99-220d0844cd9d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Slot 1"",
                    ""type"": ""Button"",
                    ""id"": ""5ba9ddcb-b2ef-486c-a5e7-a8c17a348afe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Slot 2"",
                    ""type"": ""Button"",
                    ""id"": ""897c389c-6fba-45f2-84ae-d4fcd2be60a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Slot 3"",
                    ""type"": ""Button"",
                    ""id"": ""c25c1d94-ff2f-4b2b-9f37-9fb687347887"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Slot 4"",
                    ""type"": ""Button"",
                    ""id"": ""53605ad4-ac85-4f95-9ad2-06d8cf55e828"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8064f7cd-470a-40ba-a02e-de119f550673"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c613e69d-7815-4b1a-bfaf-edb510b36876"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c8605fc1-597c-42ac-99d6-74dd4325b176"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67a7df05-b3e4-4b72-ac3d-9411b1aaf14e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf11368b-45d4-4d86-8f8e-1a8e31499046"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""63ef11e2-d57a-409c-be70-99af87401551"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6117b473-e6fa-4af3-8eef-8d6105b71417"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""id"": ""bbb1f042-db09-46aa-8fc7-13a1f1ddfd27"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d09f2106-378e-4601-8a06-8ff14895a0d0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f27c3a0f-8b80-449f-8f81-45539ac74cae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Primary Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2834de67-2547-4383-a8c7-7ccaef491cab"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50d803ae-abcf-47f8-b4c3-7486ea3b389d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Secondary Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77afe9ff-94f1-4f82-aa4b-cc91053a33dc"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da01482e-6bab-4df1-88ed-c4513b5fd5de"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Context Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f270f106-4df1-41c8-a07c-1b7cf4d48209"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Item Slot 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44904a61-5bdd-4e04-94be-08f52eadae64"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Item Slot 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab3b3b5d-2566-4776-95c8-871da3f0d88f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Item Slot 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ff128af-1012-4dc5-a537-5cabde2963cf"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Item Slot Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a67bf29b-6173-46b4-9770-a7338b2114e1"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Item Slot 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""System"",
            ""id"": ""1693560a-94e5-48f5-8737-59fa9f97a8bc"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""d938cdae-b84d-4c59-8d81-3a2f38c583e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console"",
                    ""type"": ""Button"",
                    ""id"": ""46a9d782-15ad-4522-98da-c99d8c7dd728"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Debug"",
                    ""type"": ""Button"",
                    ""id"": ""c0bca946-c08a-41e3-8dbc-59ad20355b9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Chat"",
                    ""type"": ""Button"",
                    ""id"": ""85ce6c94-3792-48f9-b338-956c09a2848e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scoreboard"",
                    ""type"": ""Button"",
                    ""id"": ""54fd12a0-cde9-49ae-94e4-588cfae91882"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f06a5f64-0667-4362-a1b9-5915a0269129"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cc27277-0b34-43ed-a233-de841ea70878"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Debug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d42efda6-609a-490f-9666-cb7d020ef4f2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""458eb4ff-af3f-45e0-8b4e-0a3a4124c8d6"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Chat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3363539-0c58-4079-954b-4ddc1a92ecdb"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Scoreboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Desktop"",
            ""basedOn"": """",
            ""bindingGroup"": ""Desktop"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Look = m_Player.GetAction("Look");
        m_Player_Move = m_Player.GetAction("Move");
        m_Player_Jump = m_Player.GetAction("Jump");
        m_Player_Sprint = m_Player.GetAction("Sprint");
        m_Player_Crouch = m_Player.GetAction("Crouch");
        m_Player_PrimaryFire = m_Player.GetAction("Primary Fire");
        m_Player_SecondaryFire = m_Player.GetAction("Secondary Fire");
        m_Player_Reload = m_Player.GetAction("Reload");
        m_Player_ContextUse = m_Player.GetAction("Context Use");
        m_Player_ItemSlotSwitch = m_Player.GetAction("Item Slot Switch");
        m_Player_ItemSlot1 = m_Player.GetAction("Item Slot 1");
        m_Player_ItemSlot2 = m_Player.GetAction("Item Slot 2");
        m_Player_ItemSlot3 = m_Player.GetAction("Item Slot 3");
        m_Player_ItemSlot4 = m_Player.GetAction("Item Slot 4");
        // System
        m_System = asset.GetActionMap("System");
        m_System_Menu = m_System.GetAction("Menu");
        m_System_Console = m_System.GetAction("Console");
        m_System_Debug = m_System.GetAction("Debug");
        m_System_Chat = m_System.GetAction("Chat");
        m_System_Scoreboard = m_System.GetAction("Scoreboard");
    }

    ~Controls()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_PrimaryFire;
    private readonly InputAction m_Player_SecondaryFire;
    private readonly InputAction m_Player_Reload;
    private readonly InputAction m_Player_ContextUse;
    private readonly InputAction m_Player_ItemSlotSwitch;
    private readonly InputAction m_Player_ItemSlot1;
    private readonly InputAction m_Player_ItemSlot2;
    private readonly InputAction m_Player_ItemSlot3;
    private readonly InputAction m_Player_ItemSlot4;
    public struct PlayerActions
    {
        private Controls m_Wrapper;
        public PlayerActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @PrimaryFire => m_Wrapper.m_Player_PrimaryFire;
        public InputAction @SecondaryFire => m_Wrapper.m_Player_SecondaryFire;
        public InputAction @Reload => m_Wrapper.m_Player_Reload;
        public InputAction @ContextUse => m_Wrapper.m_Player_ContextUse;
        public InputAction @ItemSlotSwitch => m_Wrapper.m_Player_ItemSlotSwitch;
        public InputAction @ItemSlot1 => m_Wrapper.m_Player_ItemSlot1;
        public InputAction @ItemSlot2 => m_Wrapper.m_Player_ItemSlot2;
        public InputAction @ItemSlot3 => m_Wrapper.m_Player_ItemSlot3;
        public InputAction @ItemSlot4 => m_Wrapper.m_Player_ItemSlot4;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                PrimaryFire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryFire;
                PrimaryFire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryFire;
                PrimaryFire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryFire;
                SecondaryFire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryFire;
                SecondaryFire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryFire;
                SecondaryFire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondaryFire;
                Reload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                Reload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                Reload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                ContextUse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContextUse;
                ContextUse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContextUse;
                ContextUse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContextUse;
                ItemSlotSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlotSwitch;
                ItemSlotSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlotSwitch;
                ItemSlotSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlotSwitch;
                ItemSlot1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot1;
                ItemSlot1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot1;
                ItemSlot1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot1;
                ItemSlot2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot2;
                ItemSlot2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot2;
                ItemSlot2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot2;
                ItemSlot3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot3;
                ItemSlot3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot3;
                ItemSlot3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot3;
                ItemSlot4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot4;
                ItemSlot4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot4;
                ItemSlot4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemSlot4;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Look.started += instance.OnLook;
                Look.performed += instance.OnLook;
                Look.canceled += instance.OnLook;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Sprint.started += instance.OnSprint;
                Sprint.performed += instance.OnSprint;
                Sprint.canceled += instance.OnSprint;
                Crouch.started += instance.OnCrouch;
                Crouch.performed += instance.OnCrouch;
                Crouch.canceled += instance.OnCrouch;
                PrimaryFire.started += instance.OnPrimaryFire;
                PrimaryFire.performed += instance.OnPrimaryFire;
                PrimaryFire.canceled += instance.OnPrimaryFire;
                SecondaryFire.started += instance.OnSecondaryFire;
                SecondaryFire.performed += instance.OnSecondaryFire;
                SecondaryFire.canceled += instance.OnSecondaryFire;
                Reload.started += instance.OnReload;
                Reload.performed += instance.OnReload;
                Reload.canceled += instance.OnReload;
                ContextUse.started += instance.OnContextUse;
                ContextUse.performed += instance.OnContextUse;
                ContextUse.canceled += instance.OnContextUse;
                ItemSlotSwitch.started += instance.OnItemSlotSwitch;
                ItemSlotSwitch.performed += instance.OnItemSlotSwitch;
                ItemSlotSwitch.canceled += instance.OnItemSlotSwitch;
                ItemSlot1.started += instance.OnItemSlot1;
                ItemSlot1.performed += instance.OnItemSlot1;
                ItemSlot1.canceled += instance.OnItemSlot1;
                ItemSlot2.started += instance.OnItemSlot2;
                ItemSlot2.performed += instance.OnItemSlot2;
                ItemSlot2.canceled += instance.OnItemSlot2;
                ItemSlot3.started += instance.OnItemSlot3;
                ItemSlot3.performed += instance.OnItemSlot3;
                ItemSlot3.canceled += instance.OnItemSlot3;
                ItemSlot4.started += instance.OnItemSlot4;
                ItemSlot4.performed += instance.OnItemSlot4;
                ItemSlot4.canceled += instance.OnItemSlot4;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // System
    private readonly InputActionMap m_System;
    private ISystemActions m_SystemActionsCallbackInterface;
    private readonly InputAction m_System_Menu;
    private readonly InputAction m_System_Console;
    private readonly InputAction m_System_Debug;
    private readonly InputAction m_System_Chat;
    private readonly InputAction m_System_Scoreboard;
    public struct SystemActions
    {
        private Controls m_Wrapper;
        public SystemActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_System_Menu;
        public InputAction @Console => m_Wrapper.m_System_Console;
        public InputAction @Debug => m_Wrapper.m_System_Debug;
        public InputAction @Chat => m_Wrapper.m_System_Chat;
        public InputAction @Scoreboard => m_Wrapper.m_System_Scoreboard;
        public InputActionMap Get() { return m_Wrapper.m_System; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SystemActions set) { return set.Get(); }
        public void SetCallbacks(ISystemActions instance)
        {
            if (m_Wrapper.m_SystemActionsCallbackInterface != null)
            {
                Menu.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnMenu;
                Menu.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnMenu;
                Menu.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnMenu;
                Console.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnConsole;
                Console.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnConsole;
                Console.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnConsole;
                Debug.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnDebug;
                Debug.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnDebug;
                Debug.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnDebug;
                Chat.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnChat;
                Chat.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnChat;
                Chat.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnChat;
                Scoreboard.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnScoreboard;
                Scoreboard.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnScoreboard;
                Scoreboard.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnScoreboard;
            }
            m_Wrapper.m_SystemActionsCallbackInterface = instance;
            if (instance != null)
            {
                Menu.started += instance.OnMenu;
                Menu.performed += instance.OnMenu;
                Menu.canceled += instance.OnMenu;
                Console.started += instance.OnConsole;
                Console.performed += instance.OnConsole;
                Console.canceled += instance.OnConsole;
                Debug.started += instance.OnDebug;
                Debug.performed += instance.OnDebug;
                Debug.canceled += instance.OnDebug;
                Chat.started += instance.OnChat;
                Chat.performed += instance.OnChat;
                Chat.canceled += instance.OnChat;
                Scoreboard.started += instance.OnScoreboard;
                Scoreboard.performed += instance.OnScoreboard;
                Scoreboard.canceled += instance.OnScoreboard;
            }
        }
    }
    public SystemActions @System => new SystemActions(this);
    private int m_DesktopSchemeIndex = -1;
    public InputControlScheme DesktopScheme
    {
        get
        {
            if (m_DesktopSchemeIndex == -1) m_DesktopSchemeIndex = asset.GetControlSchemeIndex("Desktop");
            return asset.controlSchemes[m_DesktopSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnPrimaryFire(InputAction.CallbackContext context);
        void OnSecondaryFire(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnContextUse(InputAction.CallbackContext context);
        void OnItemSlotSwitch(InputAction.CallbackContext context);
        void OnItemSlot1(InputAction.CallbackContext context);
        void OnItemSlot2(InputAction.CallbackContext context);
        void OnItemSlot3(InputAction.CallbackContext context);
        void OnItemSlot4(InputAction.CallbackContext context);
    }
    public interface ISystemActions
    {
        void OnMenu(InputAction.CallbackContext context);
        void OnConsole(InputAction.CallbackContext context);
        void OnDebug(InputAction.CallbackContext context);
        void OnChat(InputAction.CallbackContext context);
        void OnScoreboard(InputAction.CallbackContext context);
    }
}
