using System;
using System.Collections.Generic;
using System.Text;
using System.Xaml.Resources;


   public static class SRID
    {
            private static global::System.Resources.ResourceManager resourceMan;

            private static global::System.Globalization.CultureInfo resourceCulture;

            /// <summary>
            ///   Returns the cache used by this class ResourceManager instance
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Resources.ResourceManager ResourceManager
            {
                get
                {
                    if (object.ReferenceEquals(resourceMan, null))
                    {
                        global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Xaml.Resources.Strings", typeof(Strings).Assembly);
                        resourceMan = temp;
                    }
                    return resourceMan;
                }
            }

            /// <summary>
            ///   Rewrites the current thread's CurrentUICulture attribute
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Globalization.CultureInfo Culture
            {
                get
                {
                    return resourceCulture;
                }
                set
                {
                    resourceCulture = value;
                }
            }

            /// <summary>
            ///   The localized string for Add value to collection of type {0} threw an exception.
            /// </summary>
            internal static string AddCollection
            {
                get
                {
                    return ResourceManager.GetString("AddCollection", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Add value to dictionary of type {0} threw an exception.
            /// </summary>
            internal static string AddDictionary
            {
                get
                {
                    return ResourceManager.GetString("AddDictionary", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot determine the item type of collection type {0} because it has more than one Add method or ICollection&lt;T&gt; implementation. To make this collection type usable in XAML, add a public Add(object) method, implement System.Collections.IList or a single System.Collections.Generic.ICollection&lt;T&gt;.
            /// </summary>
            internal static string AmbiguousCollectionItemType
            {
                get
                {
                    return ResourceManager.GetString("AmbiguousCollectionItemType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot determine the item type of dictionary type {0} because it has more than one Add method or IDictionary&lt;K,V&gt; implementation. To make this dictionary type usable in XAML, add a public Add(object,object) method, implement System.Collections.IDictionary or a single System.Collections.Generic.IDictionary&lt;K,V&gt;.
            /// </summary>
            internal static string AmbiguousDictionaryItemType
            {
                get
                {
                    return ResourceManager.GetString("AmbiguousDictionaryItemType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for A child of KeyFrameAnimation in XAML must be a KeyFrame of a compatible type.
            /// </summary>
            internal static string Animation_ChildMustBeKeyFrame
            {
                get
                {
                    return ResourceManager.GetString("Animation_ChildMustBeKeyFrame", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} cannot use default {1} value of {2}.
            /// </summary>
            internal static string Animation_Invalid_DefaultValue
            {
                get
                {
                    return ResourceManager.GetString("Animation_Invalid_DefaultValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} must have either a TimeSpan for its Duration or a TimeSpan for the KeyTime of its last KeyFrame. This {0} has a Duration of {1} and a KeyTime of {2} for its last KeyFrame, so the KeyTimes cannot be resolved.
            /// </summary>
            internal static string Animation_InvalidAnimationUsingKeyFramesDuration
            {
                get
                {
                    return ResourceManager.GetString("Animation_InvalidAnimationUsingKeyFramesDuration", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not a valid {1} value for class {2}. This value might have been supplied by the base value of the property being animated or the output value of another animation applied to the same property.
            /// </summary>
            internal static string Animation_InvalidBaseValue
            {
                get
                {
                    return ResourceManager.GetString("Animation_InvalidBaseValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Resolved KeyTime for key frame at index {1} cannot be greater than resolved KeyTime for key frame at index {4}. KeyFrames[{1}]5D; has specified KeyTime {2}, which resolves to time {3}; KeyFrames[{4}]5D; has specified KeyTime {5}, which resolves to time {6}. Some KeyTimes are resolved relative to Begin time of {0} and others relative to its Duration, so some sets of KeyTimes are not valid for all Durations.
            /// </summary>
            internal static string Animation_InvalidResolvedKeyTimes
            {
                get
                {
                    return ResourceManager.GetString("Animation_InvalidResolvedKeyTimes", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {2} KeyTime value is not valid for key frame at index {1} of this {0} because it is greater than animations Duration value {3}.
            /// </summary>
            internal static string Animation_InvalidTimeKeyTime
            {
                get
                {
                    return ResourceManager.GetString("Animation_InvalidTimeKeyTime", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for KeyFrameAnimation objects cannot have text objects as children.
            /// </summary>
            internal static string Animation_NoTextChildren
            {
                get
                {
                    return ResourceManager.GetString("Animation_NoTextChildren", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Enumerating attached properties on object {0} threw an exception.
            /// </summary>
            internal static string APSException
            {
                get
                {
                    return ResourceManager.GetString("APSException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for One of the following arguments must be non-null: {0}.
            /// </summary>
            internal static string ArgumentRequired
            {
                get
                {
                    return ResourceManager.GetString("ArgumentRequired", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Array Add method is not implemented.
            /// </summary>
            internal static string ArrayAddNotImplemented
            {
                get
                {
                    return ResourceManager.GetString("ArrayAddNotImplemented", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Part between semicolon ; and equals sign = is not {0} URI {1}.
            /// </summary>
            internal static string AssemblyTagMissing
            {
                get
                {
                    return ResourceManager.GetString("AssemblyTagMissing", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Attachable events are not implemented.
            /// </summary>
            internal static string AttachableEventNotImplemented
            {
                get
                {
                    return ResourceManager.GetString("AttachableEventNotImplemented", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Attachable member {0} was not found.
            /// </summary>
            internal static string AttachableMemberNotFound
            {
                get
                {
                    return ResourceManager.GetString("AttachableMemberNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An attachable property named {1} is attached on a dictionary key {0} that is either a string or can be type-converted to string, which is not supported.
            /// </summary>
            internal static string AttachedPropertyOnDictionaryKey
            {
                get
                {
                    return ResourceManager.GetString("AttachedPropertyOnDictionaryKey", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An attachable property named {2} is attached to a property named {1}.  The property named {1} is either a string or can be type-converted to string; attaching on such properties are not supported.  For debugging, the property {1} contains an object {0}.
            /// </summary>
            internal static string AttachedPropertyOnTypeConvertedOrStringProperty
            {
                get
                {
                    return ResourceManager.GetString("AttachedPropertyOnTypeConvertedOrStringProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set property {0} on object {1} because the object is a forward or incompletely initialized reference. The unresolved name(s) are: {2}.
            /// </summary>
            internal static string AttachedPropOnFwdRefTC
            {
                get
                {
                    return ResourceManager.GetString("AttachedPropOnFwdRefTC", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An unhandled scanner attribute was encountered.
            /// </summary>
            internal static string AttributeUnhandledKind
            {
                get
                {
                    return ResourceManager.GetString("AttributeUnhandledKind", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for One of the InternalsVisibleToAttribute values in assembly {0} is not a valid assembly name. Use the format AssemblyShortName or AssemblyShortName, PublicKey=....
            /// </summary>
            internal static string BadInternalsVisibleTo1
            {
                get
                {
                    return ResourceManager.GetString("BadInternalsVisibleTo1", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for InternalsVisibleToAttribute value {0} in assembly {1} is not a valid assembly name. Use the format AssemblyShortName or AssemblyShortName, PublicKey=....
            /// </summary>
            internal static string BadInternalsVisibleTo2
            {
                get
                {
                    return ResourceManager.GetString("BadInternalsVisibleTo2", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Bad method {0} on {1}.
            /// </summary>
            internal static string BadMethod
            {
                get
                {
                    return ResourceManager.GetString("BadMethod", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Bad state in ObjectWriter. Non directive missing instance.
            /// </summary>
            internal static string BadStateObjectWriter
            {
                get
                {
                    return ResourceManager.GetString("BadStateObjectWriter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An XmlnsCompatibleWithAttribute in assembly {0} is missing a required property. Set both the NewNamespace and OldNamespace properties, or remove the XmlnsCompatibleWithAttribute.
            /// </summary>
            internal static string BadXmlnsCompat
            {
                get
                {
                    return ResourceManager.GetString("BadXmlnsCompat", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An XmlnsDefinitionAttribute in assembly {0} is missing a required property. Set both the ClrNamespace and XmlNamespace properties, or remove the XmlnsDefinitionAttribute.
            /// </summary>
            internal static string BadXmlnsDefinition
            {
                get
                {
                    return ResourceManager.GetString("BadXmlnsDefinition", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An XmlnsPrefixAttribute in assembly {0} is missing a required property. Set both the Prefix and XmlNamespace properties, or remove the XmlnsPrefixAttribute.
            /// </summary>
            internal static string BadXmlnsPrefix
            {
                get
                {
                    return ResourceManager.GetString("BadXmlnsPrefix", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Builder Stack is not empty when end of XamlNode stream was reached.
            /// </summary>
            internal static string BuilderStackNotEmptyOnClose
            {
                get
                {
                    return ResourceManager.GetString("BuilderStackNotEmptyOnClose", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed to check convertibility from type {0} using {1}. This generally indicates an incorrectly implemented TypeConverter.
            /// </summary>
            internal static string CanConvertFromFailed
            {
                get
                {
                    return ResourceManager.GetString("CanConvertFromFailed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed to check convertibility to type {0} using {1}. This generally indicates an incorrectly implemented TypeConverter.
            /// </summary>
            internal static string CanConvertToFailed
            {
                get
                {
                    return ResourceManager.GetString("CanConvertToFailed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for In markup extensions, all constructor argument values should be atoms.  For the object of type {0}, one or more argument values are not atomic.
            /// </summary>
            internal static string CannotAddPositionalParameters
            {
                get
                {
                    return ResourceManager.GetString("CannotAddPositionalParameters", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot convert string value {0} to type {1}.
            /// </summary>
            internal static string CannotConvertStringToType
            {
                get
                {
                    return ResourceManager.GetString("CannotConvertStringToType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot convert type {0} to {1}.
            /// </summary>
            internal static string CannotConvertType
            {
                get
                {
                    return ResourceManager.GetString("CannotConvertType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot create an instance of {0} because XamlType is not valid.
            /// </summary>
            internal static string CannotCreateBadEventDelegate
            {
                get
                {
                    return ResourceManager.GetString("CannotCreateBadEventDelegate", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot create an instance of {0} because XamlType is not valid.
            /// </summary>
            internal static string CannotCreateBadType
            {
                get
                {
                    return ResourceManager.GetString("CannotCreateBadType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot find Assembly {0} in URI {1}.
            /// </summary>
            internal static string CannotFindAssembly
            {
                get
                {
                    return ResourceManager.GetString("CannotFindAssembly", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot modify a read-only container.
            /// </summary>
            internal static string CannotModifyReadOnlyContainer
            {
                get
                {
                    return ResourceManager.GetString("CannotModifyReadOnlyContainer", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot reassign a previously set SchemaContext.
            /// </summary>
            internal static string CannotReassignSchemaContext
            {
                get
                {
                    return ResourceManager.GetString("CannotReassignSchemaContext", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot resolve type {0} for method {1}.
            /// </summary>
            internal static string CannotResolveTypeForFactoryMethod
            {
                get
                {
                    return ResourceManager.GetString("CannotResolveTypeForFactoryMethod", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot get part or part information from a write-only container.
            /// </summary>
            internal static string CannotRetrievePartsOfWriteOnlyContainer
            {
                get
                {
                    return ResourceManager.GetString("CannotRetrievePartsOfWriteOnlyContainer", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for BaseUri can only be set once at the root node (XamlXmlReader may provide a default at the root node).
            /// </summary>
            internal static string CannotSetBaseUri
            {
                get
                {
                    return ResourceManager.GetString("CannotSetBaseUri", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set SchemaContext on ObjectWriter.
            /// </summary>
            internal static string CannotSetSchemaContext
            {
                get
                {
                    return ResourceManager.GetString("CannotSetSchemaContext", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set SchemaContext to null.
            /// </summary>
            internal static string CannotSetSchemaContextNull
            {
                get
                {
                    return ResourceManager.GetString("CannotSetSchemaContextNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write on a closed XamlWriter.
            /// </summary>
            internal static string CannotWriteClosedWriter
            {
                get
                {
                    return ResourceManager.GetString("CannotWriteClosedWriter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The value {1} contains significant white space(s) but &quot;xml:space = preserve&quot; cannot be written down on the member {0}.
            /// </summary>
            internal static string CannotWriteXmlSpacePreserveOnMember
            {
                get
                {
                    return ResourceManager.GetString("CannotWriteXmlSpacePreserveOnMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot assign root instance of type {0} to type {1}.
            /// </summary>
            internal static string CantAssignRootInstance
            {
                get
                {
                    return ResourceManager.GetString("CantAssignRootInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot create unknown type {0}.
            /// </summary>
            internal static string CantCreateUnknownType
            {
                get
                {
                    return ResourceManager.GetString("CantCreateUnknownType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot get write-only property {0}.
            /// </summary>
            internal static string CantGetWriteonlyProperty
            {
                get
                {
                    return ResourceManager.GetString("CantGetWriteonlyProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set read-only property {0}.
            /// </summary>
            internal static string CantSetReadonlyProperty
            {
                get
                {
                    return ResourceManager.GetString("CantSetReadonlyProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set unknown member {0}.
            /// </summary>
            internal static string CantSetUnknownProperty
            {
                get
                {
                    return ResourceManager.GetString("CantSetUnknownProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Close called while inside a deferred load section.
            /// </summary>
            internal static string CloseInsideTemplate
            {
                get
                {
                    return ResourceManager.GetString("CloseInsideTemplate", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Must close XamlWriter before reading from XamlNodeList.
            /// </summary>
            internal static string CloseXamlWriterBeforeReading
            {
                get
                {
                    return ResourceManager.GetString("CloseXamlWriterBeforeReading", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot add instance of type {1} to a collection of type {0}. Only items of type {2} are allowed.
            /// </summary>
            internal static string Collection_BadType
            {
                get
                {
                    return ResourceManager.GetString("Collection_BadType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot pass multidimensional array to the CopyTo method on a collection.
            /// </summary>
            internal static string Collection_CopyTo_ArrayCannotBeMultidimensional
            {
                get
                {
                    return ResourceManager.GetString("Collection_CopyTo_ArrayCannotBeMultidimensional", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} parameter value is equal to or greater than the length of the {1} parameter value.
            /// </summary>
            internal static string Collection_CopyTo_IndexGreaterThanOrEqualToArrayLength
            {
                get
                {
                    return ResourceManager.GetString("Collection_CopyTo_IndexGreaterThanOrEqualToArrayLength", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The number of elements in this collection is greater than the available space from {0} to the end of destination {1}.
            /// </summary>
            internal static string Collection_CopyTo_NumberOfElementsExceedsArrayLength
            {
                get
                {
                    return ResourceManager.GetString("Collection_CopyTo_NumberOfElementsExceedsArrayLength", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Collection {0} cannot contain null values.
            /// </summary>
            internal static string CollectionCannotContainNulls
            {
                get
                {
                    return ResourceManager.GetString("CollectionCannotContainNulls", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The number of elements in this collection must be less than or equal to {0}.
            /// </summary>
            internal static string CollectionNumberOfElementsMustBeLessOrEqualTo
            {
                get
                {
                    return ResourceManager.GetString("CollectionNumberOfElementsMustBeLessOrEqualTo", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed attempting to create an Implicit Type with a constructor.
            /// </summary>
            internal static string ConstructImplicitType
            {
                get
                {
                    return ResourceManager.GetString("ConstructImplicitType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The invocation of the constructor on type {0} that matches the specified binding constraints threw an exception.
            /// </summary>
            internal static string ConstructorInvocation
            {
                get
                {
                    return ResourceManager.GetString("ConstructorInvocation", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write the given positional parameters because a matching constructor was not found.
            /// </summary>
            internal static string ConstructorNotFoundForGivenPositionalParameters
            {
                get
                {
                    return ResourceManager.GetString("ConstructorNotFoundForGivenPositionalParameters", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Converter type {0} doesnt derive from expected base type {1}.
            /// </summary>
            internal static string ConverterMustDeriveFromBase
            {
                get
                {
                    return ResourceManager.GetString("ConverterMustDeriveFromBase", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} ValueSerializer cannot convert from {1}.
            /// </summary>
            internal static string ConvertFromException
            {
                get
                {
                    return ResourceManager.GetString("ConvertFromException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} ValueSerializer cannot convert {1} to {2}.
            /// </summary>
            internal static string ConvertToException
            {
                get
                {
                    return ResourceManager.GetString("ConvertToException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed to add attached properties to item in ConditionalWeakTable.
            /// </summary>
            internal static string DefaultAttachablePropertyStoreCannotAddInstance
            {
                get
                {
                    return ResourceManager.GetString("DefaultAttachablePropertyStoreCannotAddInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Deferred load threw an exception.
            /// </summary>
            internal static string DeferredLoad
            {
                get
                {
                    return ResourceManager.GetString("DeferredLoad", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Deferred member was not collected in {0}.
            /// </summary>
            internal static string DeferredPropertyNotCollected
            {
                get
                {
                    return ResourceManager.GetString("DeferredPropertyNotCollected", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Save of deferred-load content threw an exception.
            /// </summary>
            internal static string DeferredSave
            {
                get
                {
                    return ResourceManager.GetString("DeferredSave", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot get a XamlDeferringLoader from XamlValueConverter {0} because its ConverterInstance property is null.
            /// </summary>
            internal static string DeferringLoaderInstanceNull
            {
                get
                {
                    return ResourceManager.GetString("DeferringLoaderInstanceNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0}.{1} Depends on {0}.{1}, which was not set.
            /// </summary>
            internal static string DependsOnMissing
            {
                get
                {
                    return ResourceManager.GetString("DependsOnMissing", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Dictionary of type {0} cannot add key {1}. A TypeConverter will convert the key to type {2}. To avoid seeing this error, override System.Collections.IDictionary.Add and perform the conversion there.
            /// </summary>
            internal static string DictionaryFirstChanceException
            {
                get
                {
                    return ResourceManager.GetString("DictionaryFirstChanceException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Directive getter is not implemented.
            /// </summary>
            internal static string DirectiveGetter
            {
                get
                {
                    return ResourceManager.GetString("DirectiveGetter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Directive {0} must be a value of type string. Remove this directive or change it to a string value.
            /// </summary>
            internal static string DirectiveMustBeString
            {
                get
                {
                    return ResourceManager.GetString("DirectiveMustBeString", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Directive {0} is only allowed on the root object. Remove this directive or move it to the root of the document.
            /// </summary>
            internal static string DirectiveNotAtRoot
            {
                get
                {
                    return ResourceManager.GetString("DirectiveNotAtRoot", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Directive {0} was not found in TargetNamespace {1}.
            /// </summary>
            internal static string DirectiveNotFound
            {
                get
                {
                    return ResourceManager.GetString("DirectiveNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} property has already been set on {1}.
            /// </summary>
            internal static string DuplicateMemberSet
            {
                get
                {
                    return ResourceManager.GetString("DuplicateMemberSet", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for There is more than one XmlnsCompatibleWithAttribute in assembly {0} for OldNamespace {1}. Remove the extra attribute(s).
            /// </summary>
            internal static string DuplicateXmlnsCompat
            {
                get
                {
                    return ResourceManager.GetString("DuplicateXmlnsCompat", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for There are conflicting XmlnsCompatibleWithAttributes in assemblies {0} and {1} for OldNamespace {2}. Change the attributes to have the same NewNamespace, or pass a non-conflicting set of Reference Assemblies in the XamlSchemaContext constructor.
            /// </summary>
            internal static string DuplicateXmlnsCompatAcrossAssemblies
            {
                get
                {
                    return ResourceManager.GetString("DuplicateXmlnsCompatAcrossAssemblies", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} enumeration value is not valid.
            /// </summary>
            internal static string Enum_Invalid
            {
                get
                {
                    return ResourceManager.GetString("Enum_Invalid", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No current object to return.
            /// </summary>
            internal static string Enumerator_VerifyContext
            {
                get
                {
                    return ResourceManager.GetString("Enumerator_VerifyContext", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} event cannot be assigned a value that is not assignable to {1}.
            /// </summary>
            internal static string EventCannotBeAssigned
            {
                get
                {
                    return ResourceManager.GetString("EventCannotBeAssigned", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters due to the lack of a default constructor on the markup extension that contains the positional parameters.  Try moving the positional parameter member earlier in the node stream, to a place where XamlXmlWriter can still write attributes.
            /// </summary>
            internal static string ExpandPositionalParametersinTypeWithNoDefaultConstructor
            {
                get
                {
                    return ResourceManager.GetString("ExpandPositionalParametersinTypeWithNoDefaultConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters since UnderlyingType on type {0} is null.  Try moving the positional parameter member earlier in the node stream, to place where XamlXmlWriter can still write attributes.
            /// </summary>
            internal static string ExpandPositionalParametersWithoutUnderlyingType
            {
                get
                {
                    return ResourceManager.GetString("ExpandPositionalParametersWithoutUnderlyingType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters since not all properties are writable.  Try moving the positional parameter member earlier in the node stream, to a place where XamlXmlWriter can still write attributes.
            /// </summary>
            internal static string ExpandPositionalParametersWithReadOnlyProperties
            {
                get
                {
                    return ResourceManager.GetString("ExpandPositionalParametersWithReadOnlyProperties", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Expected permission of type XamlLoadPermission.
            /// </summary>
            internal static string ExpectedLoadPermission
            {
                get
                {
                    return ResourceManager.GetString("ExpectedLoadPermission", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Expected value of type ObjectMarkupInfo.
            /// </summary>
            internal static string ExpectedObjectMarkupInfo
            {
                get
                {
                    return ResourceManager.GetString("ExpectedObjectMarkupInfo", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Assembly name {0} is not fully qualified. The Name, Version, Culture, and PublicKeyToken must all be provided.
            /// </summary>
            internal static string ExpectedQualifiedAssemblyName
            {
                get
                {
                    return ResourceManager.GetString("ExpectedQualifiedAssemblyName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type name {0} is not assembly-qualified. You can obtain this value from System.Type.AssemblyQualifiedName.
            /// </summary>
            internal static string ExpectedQualifiedTypeName
            {
                get
                {
                    return ResourceManager.GetString("ExpectedQualifiedTypeName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The factory method {0} that matches the specified binding constraints returned null.
            /// </summary>
            internal static string FactoryReturnedNull
            {
                get
                {
                    return ResourceManager.GetString("FactoryReturnedNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Input file or data stream does not conform to the expected file format specification.
            /// </summary>
            internal static string FileFormatException
            {
                get
                {
                    return ResourceManager.GetString("FileFormatException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} file does not conform to the expected file format specification.
            /// </summary>
            internal static string FileFormatExceptionWithFileName
            {
                get
                {
                    return ResourceManager.GetString("FileFormatExceptionWithFileName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Could not load file or assembly {0} or one of its dependencies. The system cannot find the specified file.
            /// </summary>
            internal static string FileNotFoundExceptionMessage
            {
                get
                {
                    return ResourceManager.GetString("FileNotFoundExceptionMessage", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Attempt to reference named object(s) {0} which have not yet been defined. Forward references, or references to objects that contain forward references, are not supported on directives other than Key.
            /// </summary>
            internal static string ForwardRefDirectives
            {
                get
                {
                    return ResourceManager.GetString("ForwardRefDirectives", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Specified value of type {0} must have IsFrozen set to false to modify.
            /// </summary>
            internal static string Freezable_CantBeFrozen
            {
                get
                {
                    return ResourceManager.GetString("Freezable_CantBeFrozen", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot promote from Array.
            /// </summary>
            internal static string FrugalList_CannotPromoteBeyondArray
            {
                get
                {
                    return ResourceManager.GetString("FrugalList_CannotPromoteBeyondArray", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot promote from {0} to {1} because the target map is too small.
            /// </summary>
            internal static string FrugalList_TargetMapCannotHoldAllData
            {
                get
                {
                    return ResourceManager.GetString("FrugalList_TargetMapCannotHoldAllData", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Getting instance of {0} threw an exception.
            /// </summary>
            internal static string GetConverterInstance
            {
                get
                {
                    return ResourceManager.GetString("GetConverterInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Retrieving items in collection or dictionary of type {0} threw an exception.
            /// </summary>
            internal static string GetItemsException
            {
                get
                {
                    return ResourceManager.GetString("GetItemsException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XamlTypeInvoker.GetItems returned null for type {0}. This generally indicates an incorrectly implemented collection type.
            /// </summary>
            internal static string GetItemsReturnedNull
            {
                get
                {
                    return ResourceManager.GetString("GetItemsReturnedNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Collection property {0}.{1} is null.
            /// </summary>
            internal static string GetObjectNull
            {
                get
                {
                    return ResourceManager.GetString("GetObjectNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot get TargetType on a non-attachable Member.
            /// </summary>
            internal static string GetTargetTypeOnNonAttachableMember
            {
                get
                {
                    return ResourceManager.GetString("GetTargetTypeOnNonAttachableMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Either getter or setter must be non-null.
            /// </summary>
            internal static string GetterOrSetterRequired
            {
                get
                {
                    return ResourceManager.GetString("GetterOrSetterRequired", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Get property {0} threw an exception.
            /// </summary>
            internal static string GetValue
            {
                get
                {
                    return ResourceManager.GetString("GetValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Attached property getter methods must have one parameter and a non-void return type.
            /// </summary>
            internal static string IncorrectGetterParamNum
            {
                get
                {
                    return ResourceManager.GetString("IncorrectGetterParamNum", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Attached property setter and attached event adder methods must have two parameters.
            /// </summary>
            internal static string IncorrectSetterParamNum
            {
                get
                {
                    return ResourceManager.GetString("IncorrectSetterParamNum", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Initialization of {0} threw an exception.
            /// </summary>
            internal static string InitializationGuard
            {
                get
                {
                    return ResourceManager.GetString("InitializationGuard", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type {0} cannot be initialized from text (XamlLanguage.Initialization).  Add a TypeConverter to this type or change the XAML to use a constructor or factory method.
            /// </summary>
            internal static string InitializationSyntaxWithoutTypeConverter
            {
                get
                {
                    return ResourceManager.GetString("InitializationSyntaxWithoutTypeConverter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Character {0} was unexpected in string {1}.  Invalid XAML type name.
            /// </summary>
            internal static string InvalidCharInTypeName
            {
                get
                {
                    return ResourceManager.GetString("InvalidCharInTypeName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Encountered a closing BracketCharacter {0} without a corresponding opening BracketCharacter.
            /// </summary>
            internal static string InvalidClosingBracketCharacers
            {
                get
                {
                    return ResourceManager.GetString("InvalidClosingBracketCharacers", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Event argument is invalid.
            /// </summary>
            internal static string InvalidEvent
            {
                get
                {
                    return ResourceManager.GetString("InvalidEvent", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Invalid expression: {0}
            /// </summary>
            internal static string InvalidExpression
            {
                get
                {
                    return ResourceManager.GetString("InvalidExpression", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for PermissionState value {0} is not valid for this Permission.
            /// </summary>
            internal static string InvalidPermissionStateValue
            {
                get
                {
                    return ResourceManager.GetString("InvalidPermissionStateValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Permission type is not valid. Expected {0}.
            /// </summary>
            internal static string InvalidPermissionType
            {
                get
                {
                    return ResourceManager.GetString("InvalidPermissionType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type argument {0} is not a valid type.
            /// </summary>
            internal static string InvalidTypeArgument
            {
                get
                {
                    return ResourceManager.GetString("InvalidTypeArgument", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The string {0} is not a valid XAML type name list. Type name lists are comma-delimited lists of types; such as x:String, x:Int32.
            /// </summary>
            internal static string InvalidTypeListString
            {
                get
                {
                    return ResourceManager.GetString("InvalidTypeListString", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The string {0} is not a valid XAML type name. Type names contain an optional prefix, a name, and optional type arguments; such as String, x:Int32, g:Dictionary(x:String,x:Int32).
            /// </summary>
            internal static string InvalidTypeString
            {
                get
                {
                    return ResourceManager.GetString("InvalidTypeString", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not a valid XAML member name.
            /// </summary>
            internal static string InvalidXamlMemberName
            {
                get
                {
                    return ResourceManager.GetString("InvalidXamlMemberName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Construction directive {0} must be an attribute or the first property element.
            /// </summary>
            internal static string LateConstructionDirective
            {
                get
                {
                    return ResourceManager.GetString("LateConstructionDirective", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} Line number {1} and line position {2}.
            /// </summary>
            internal static string LineNumberAndPosition
            {
                get
                {
                    return ResourceManager.GetString("LineNumberAndPosition", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} Line number {1}.
            /// </summary>
            internal static string LineNumberOnly
            {
                get
                {
                    return ResourceManager.GetString("LineNumberOnly", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for List collection is not an IList.
            /// </summary>
            internal static string ListNotIList
            {
                get
                {
                    return ResourceManager.GetString("ListNotIList", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for BracketCharacter {0} does not have a corresponding opening/closing BracketCharacter.
            /// </summary>
            internal static string MalformedBracketCharacters
            {
                get
                {
                    return ResourceManager.GetString("MalformedBracketCharacters", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot parse the malformed property name {0}.
            /// </summary>
            internal static string MalformedPropertyName
            {
                get
                {
                    return ResourceManager.GetString("MalformedPropertyName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Items in the array must be type {0}. One or more items cannot be cast to this type.
            /// </summary>
            internal static string MarkupExtensionArrayBadType
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionArrayBadType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Must set Type before calling ProvideValue on ArrayExtension.
            /// </summary>
            internal static string MarkupExtensionArrayType
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionArrayType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} StaticExtension value cannot be resolved to an enumeration, static field, or static property.
            /// </summary>
            internal static string MarkupExtensionBadStatic
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionBadStatic", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Markup extension {0} requires {1} be implemented in the IServiceProvider for ProvideValue.
            /// </summary>
            internal static string MarkupExtensionNoContext
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionNoContext", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for StaticExtension must have Member property set before ProvideValue can be called.
            /// </summary>
            internal static string MarkupExtensionStaticMember
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionStaticMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for TypeExtension must have TypeName property set before ProvideValue can be called.
            /// </summary>
            internal static string MarkupExtensionTypeName
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionTypeName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} string is not valid for type.
            /// </summary>
            internal static string MarkupExtensionTypeNameBad
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionTypeNameBad", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot determine the positional parameters for type {0} because it has more than one constructor overload with {1} parameters. To make this markup extension usable in XAML, remove the duplicate constructor overload(s) or set XamlSchemaContextSettings.SupportMarkupExtensionsWithDuplicateArity to true.
            /// </summary>
            internal static string MarkupExtensionWithDuplicateArity
            {
                get
                {
                    return ResourceManager.GetString("MarkupExtensionWithDuplicateArity", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The name of the member {0} contains characters that are invalid in XAML.
            /// </summary>
            internal static string MemberHasInvalidXamlName
            {
                get
                {
                    return ResourceManager.GetString("MemberHasInvalidXamlName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Member {0} on type {1} is internal.
            /// </summary>
            internal static string MemberIsInternal
            {
                get
                {
                    return ResourceManager.GetString("MemberIsInternal", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The invocation of a method {0} that matches the specified binding constraints threw an exception.
            /// </summary>
            internal static string MethodInvocation
            {
                get
                {
                    return ResourceManager.GetString("MethodInvocation", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No local assembly provided to complete URI={0}.
            /// </summary>
            internal static string MissingAssemblyName
            {
                get
                {
                    return ResourceManager.GetString("MissingAssemblyName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing case {0} in DeferringWriter{1} method.
            /// </summary>
            internal static string MissingCase
            {
                get
                {
                    return ResourceManager.GetString("MissingCase", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing case in Default processing of XamlNodes.
            /// </summary>
            internal static string MissingCaseXamlNodes
            {
                get
                {
                    return ResourceManager.GetString("MissingCaseXamlNodes", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected equals sign = following {0}. Check for a missing comma separator.
            /// </summary>
            internal static string MissingComma1
            {
                get
                {
                    return ResourceManager.GetString("MissingComma1", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected equals sign = following {0}={1}. Check for a missing comma separator.
            /// </summary>
            internal static string MissingComma2
            {
                get
                {
                    return ResourceManager.GetString("MissingComma2", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing implicit property case.
            /// </summary>
            internal static string MissingImplicitProperty
            {
                get
                {
                    return ResourceManager.GetString("MissingImplicitProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing case for ImplicitPropertyType.
            /// </summary>
            internal static string MissingImplicitPropertyTypeCase
            {
                get
                {
                    return ResourceManager.GetString("MissingImplicitPropertyTypeCase", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing key value on {0} object.
            /// </summary>
            internal static string MissingKey
            {
                get
                {
                    return ResourceManager.GetString("MissingKey", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing case handler in LookupPropertyBit.
            /// </summary>
            internal static string MissingLookPropertyBit
            {
                get
                {
                    return ResourceManager.GetString("MissingLookPropertyBit", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Service provider is missing the IXamlNameProvider service.
            /// </summary>
            internal static string MissingNameProvider
            {
                get
                {
                    return ResourceManager.GetString("MissingNameProvider", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Service provider is missing the INameResolver service.
            /// </summary>
            internal static string MissingNameResolver
            {
                get
                {
                    return ResourceManager.GetString("MissingNameResolver", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing case in ClrType Member lookup.
            /// </summary>
            internal static string MissingPropertyCaseClrType
            {
                get
                {
                    return ResourceManager.GetString("MissingPropertyCaseClrType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing {0} in URI {1}.
            /// </summary>
            internal static string MissingTagInNamespace
            {
                get
                {
                    return ResourceManager.GetString("MissingTagInNamespace", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Creating from text without a TypeConverter is not allowed.
            /// </summary>
            internal static string MissingTypeConverter
            {
                get
                {
                    return ResourceManager.GetString("MissingTypeConverter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} must be of type {1}.
            /// </summary>
            internal static string MustBeOfType
            {
                get
                {
                    return ResourceManager.GetString("MustBeOfType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Reference must have a Name to resolve.
            /// </summary>
            internal static string MustHaveName
            {
                get
                {
                    return ResourceManager.GetString("MustHaveName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This setter is not intended to be used directly from your code. Do not call this setter.
            /// </summary>
            internal static string MustNotCallSetter
            {
                get
                {
                    return ResourceManager.GetString("MustNotCallSetter", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Name resolution failure. {0} was not found.
            /// </summary>
            internal static string NameNotFound
            {
                get
                {
                    return ResourceManager.GetString("NameNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot register duplicate name {0} in this scope.
            /// </summary>
            internal static string NameScopeDuplicateNamesNotAllowed
            {
                get
                {
                    return ResourceManager.GetString("NameScopeDuplicateNamesNotAllowed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Could not register named object. {0}
            /// </summary>
            internal static string NameScopeException
            {
                get
                {
                    return ResourceManager.GetString("NameScopeException", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} name is not valid for identifier.
            /// </summary>
            internal static string NameScopeInvalidIdentifierName
            {
                get
                {
                    return ResourceManager.GetString("NameScopeInvalidIdentifierName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Name cannot be an empty string.
            /// </summary>
            internal static string NameScopeNameNotEmptyString
            {
                get
                {
                    return ResourceManager.GetString("NameScopeNameNotEmptyString", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Name {0} was not found.
            /// </summary>
            internal static string NameScopeNameNotFound
            {
                get
                {
                    return ResourceManager.GetString("NameScopeNameNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot attach NameScope to null root instance.
            /// </summary>
            internal static string NameScopeOnRootInstance
            {
                get
                {
                    return ResourceManager.GetString("NameScopeOnRootInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The prefix xml is reserved.
            /// </summary>
            internal static string NamespaceDeclarationCannotBeXml
            {
                get
                {
                    return ResourceManager.GetString("NamespaceDeclarationCannotBeXml", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for NamespaceDeclaration.Namespace cannot be null.  Provide a value for this property.
            /// </summary>
            internal static string NamespaceDeclarationNamespaceCannotBeNull
            {
                get
                {
                    return ResourceManager.GetString("NamespaceDeclarationNamespaceCannotBeNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for NamespaceDeclaration.Prefix cannot be null.  Provide a value for this property.
            /// </summary>
            internal static string NamespaceDeclarationPrefixCannotBeNull
            {
                get
                {
                    return ResourceManager.GetString("NamespaceDeclarationPrefixCannotBeNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Namespace {0} was not found in scope.
            /// </summary>
            internal static string NamespaceNotFound
            {
                get
                {
                    return ResourceManager.GetString("NamespaceNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No Add methods found on type {0} for a value of type {1}.
            /// </summary>
            internal static string NoAddMethodFound
            {
                get
                {
                    return ResourceManager.GetString("NoAddMethodFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not allowed in attribute usage.
            /// </summary>
            internal static string NoAttributeUsage
            {
                get
                {
                    return ResourceManager.GetString("NoAttributeUsage", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No matching constructor found on type {0}. You can use the Arguments or FactoryMethod directives to construct this type.
            /// </summary>
            internal static string NoConstructor
            {
                get
                {
                    return ResourceManager.GetString("NoConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for A Constructor for {0} with {1} arguments was not found.
            /// </summary>
            internal static string NoConstructorWithNArugments
            {
                get
                {
                    return ResourceManager.GetString("NoConstructorWithNArugments", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No default constructor found for type {0}. You can use the Arguments or FactoryMethod directives to construct this type.
            /// </summary>
            internal static string NoDefaultConstructor
            {
                get
                {
                    return ResourceManager.GetString("NoDefaultConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not allowed in element usage.
            /// </summary>
            internal static string NoElementUsage
            {
                get
                {
                    return ResourceManager.GetString("NoElementUsage", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type with positional parameters is not a markup extension.
            /// </summary>
            internal static string NonMEWithPositionalParameters
            {
                get
                {
                    return ResourceManager.GetString("NonMEWithPositionalParameters", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Missing StartMember on Type {0} before EndMember.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_EM
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_EM", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: EndMember must follow StartObject and StartMember.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_EM_noType
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_EM_noType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: GetObject requires a StartMember after StartObject {0}.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_GO
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_GO", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: GetObject must follow a StartObject and StartMember.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_GO_noType
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_GO_noType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: {0}={1} Namespace Declaration requires a StartMember after StartObject {2}.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_NS
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_NS", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: StartObject {0} requires a StartMember after StartObject {1}.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_SO
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_SO", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Value of {0} requires a StartMember after StartObject {1}.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_V
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_V", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Value of {0} must follow a StartObject and StartMember.
            /// </summary>
            internal static string NoPropertyInCurrentFrame_V_noType
            {
                get
                {
                    return ResourceManager.GetString("NoPropertyInCurrentFrame_V_noType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for No constructor with {0} arguments for {1}.
            /// </summary>
            internal static string NoSuchConstructor
            {
                get
                {
                    return ResourceManager.GetString("NoSuchConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0}.{1} is not an ambient property.
            /// </summary>
            internal static string NotAmbientProperty
            {
                get
                {
                    return ResourceManager.GetString("NotAmbientProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not an ambient type.
            /// </summary>
            internal static string NotAmbientType
            {
                get
                {
                    return ResourceManager.GetString("NotAmbientType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The type {0} is not assignable from the type {1}.
            /// </summary>
            internal static string NotAssignableFrom
            {
                get
                {
                    return ResourceManager.GetString("NotAssignableFrom", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for [{0}({1})]5D; on {2} is not a property declared on this type.
            /// </summary>
            internal static string NotDeclaringTypeAttributeProperty
            {
                get
                {
                    return ResourceManager.GetString("NotDeclaringTypeAttributeProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is not supported on directive members.
            /// </summary>
            internal static string NotSupportedOnDirective
            {
                get
                {
                    return ResourceManager.GetString("NotSupportedOnDirective", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is not supported on unknown members.
            /// </summary>
            internal static string NotSupportedOnUnknownMember
            {
                get
                {
                    return ResourceManager.GetString("NotSupportedOnUnknownMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is not supported on unknown types.
            /// </summary>
            internal static string NotSupportedOnUnknownType
            {
                get
                {
                    return ResourceManager.GetString("NotSupportedOnUnknownType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Missing CurrentObject before EndObject.
            /// </summary>
            internal static string NoTypeInCurrentFrame_EO
            {
                get
                {
                    return ResourceManager.GetString("NoTypeInCurrentFrame_EO", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Missing StartObject before StartMember {0}.
            /// </summary>
            internal static string NoTypeInCurrentFrame_SM
            {
                get
                {
                    return ResourceManager.GetString("NoTypeInCurrentFrame_SM", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Argument should be a Type Converter, Markup Extension or Null.
            /// </summary>
            internal static string ObjectNotTcOrMe
            {
                get
                {
                    return ResourceManager.GetString("ObjectNotTcOrMe", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type {0} not visible. If the type is local, please set the LocalAssembly field in XamlReaderSettings.
            /// </summary>
            internal static string ObjectReader_TypeNotVisible
            {
                get
                {
                    return ResourceManager.GetString("ObjectReader_TypeNotVisible", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to find an attachable property named {0} on type {1}.
            /// </summary>
            internal static string ObjectReaderAttachedPropertyNotFound
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderAttachedPropertyNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to locate MemberMarkupInfo.DictionaryEntriesFromGeneric method.
            /// </summary>
            internal static string ObjectReaderDictionaryMethod1NotFound
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderDictionaryMethod1NotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for InstanceDescriptor did not provide the correct number of arguments.
            /// </summary>
            internal static string ObjectReaderInstanceDescriptorIncompatibleArguments
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderInstanceDescriptorIncompatibleArguments", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for InstanceDescriptor provided an argument of type {0} where a parameter of type {1} was expected.
            /// </summary>
            internal static string ObjectReaderInstanceDescriptorIncompatibleArgumentTypes
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderInstanceDescriptorIncompatibleArgumentTypes", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for InstanceDescriptor did not provide a valid constructor or method.
            /// </summary>
            internal static string ObjectReaderInstanceDescriptorInvalidMethod
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderInstanceDescriptorInvalidMethod", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Multidimensional arrays not supported.
            /// </summary>
            internal static string ObjectReaderMultidimensionalArrayNotSupported
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderMultidimensionalArrayNotSupported", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to serialize type {0}.  Verify that the type is public and either has a default constructor or an instance descriptor.
            /// </summary>
            internal static string ObjectReaderNoDefaultConstructor
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderNoDefaultConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to find a suitable constructor for the specified constructor arguments on type {0}.
            /// </summary>
            internal static string ObjectReaderNoMatchingConstructor
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderNoMatchingConstructor", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to read objects of the type �{0}� because there are no accessible constructors. To allow this type to be used in XAML, add a default constructor, use ConstructorArgumentAttribute, or provide an InstanceDescriptor.
            /// </summary>
            internal static string ObjectReaderTypeCannotRoundtrip
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderTypeCannotRoundtrip", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to read objects of the type {0}.  Nested types are not supported.
            /// </summary>
            internal static string ObjectReaderTypeIsNested
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderTypeIsNested", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} blocked the use of type {1} in XAML. If you want to serialize this type, change {0}.GetXamlType to return a non-null value for this type, or pass a different value in the schemaContext parameter of the XamlObjectReader constructor.
            /// </summary>
            internal static string ObjectReaderTypeNotAllowed
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderTypeNotAllowed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An element with the name {0} has already been registered in this scope.
            /// </summary>
            internal static string ObjectReaderXamlNamedElementAlreadyRegistered
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderXamlNamedElementAlreadyRegistered", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The name property {0} on type {1} must be of type System.String.
            /// </summary>
            internal static string ObjectReaderXamlNamePropertyMustBeString
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderXamlNamePropertyMustBeString", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The object graph contains multiple references to an instance of type {0} and the serializer cannot find a commonly visible location to write the instance. You should examine your use of name scopes.
            /// </summary>
            internal static string ObjectReaderXamlNameScopeResultsInClonedObject
            {
                get
                {
                    return ResourceManager.GetString("ObjectReaderXamlNameScopeResultsInClonedObject", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} blocked the use of type {1} in XAML. If you want to load this type, change {0}.GetXamlType to return a non-null value for this type, or pass a different value in the schemaContext parameter of the XamlObjectWriter constructor.
            /// </summary>
            internal static string ObjectWriterTypeNotAllowed
            {
                get
                {
                    return ResourceManager.GetString("ObjectWriterTypeNotAllowed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is only supported on collection types.
            /// </summary>
            internal static string OnlySupportedOnCollections
            {
                get
                {
                    return ResourceManager.GetString("OnlySupportedOnCollections", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is only supported on collection and dictionary types.
            /// </summary>
            internal static string OnlySupportedOnCollectionsAndDictionaries
            {
                get
                {
                    return ResourceManager.GetString("OnlySupportedOnCollectionsAndDictionaries", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This operation is only supported on dictionary types.
            /// </summary>
            internal static string OnlySupportedOnDictionaries
            {
                get
                {
                    return ResourceManager.GetString("OnlySupportedOnDictionaries", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Missing EndMember for {0}.{1} before EndObject.
            /// </summary>
            internal static string OpenPropertyInCurrentFrame_EO
            {
                get
                {
                    return ResourceManager.GetString("OpenPropertyInCurrentFrame_EO", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Missing EndMember for {0}.{1} before StartMember {2}.
            /// </summary>
            internal static string OpenPropertyInCurrentFrame_SM
            {
                get
                {
                    return ResourceManager.GetString("OpenPropertyInCurrentFrame_SM", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Parameter must be greater than or equal to zero.
            /// </summary>
            internal static string ParameterCannotBeNegative
            {
                get
                {
                    return ResourceManager.GetString("ParameterCannotBeNegative", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The property element {0} is not contained by an object element.
            /// </summary>
            internal static string ParentlessPropertyElement
            {
                get
                {
                    return ResourceManager.GetString("ParentlessPropertyElement", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot load assembly {0} because a different version of that same assembly is loaded {1}.
            /// </summary>
            internal static string ParserAssemblyLoadVersionMismatch
            {
                get
                {
                    return ResourceManager.GetString("ParserAssemblyLoadVersionMismatch", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Too many attributes are specified for {0}.
            /// </summary>
            internal static string ParserAttributeArgsHigh
            {
                get
                {
                    return ResourceManager.GetString("ParserAttributeArgsHigh", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} requires more attributes.
            /// </summary>
            internal static string ParserAttributeArgsLow
            {
                get
                {
                    return ResourceManager.GetString("ParserAttributeArgsLow", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for GetPositionalParameters returned the wrong length vector.
            /// </summary>
            internal static string PositionalParamsWrongLength
            {
                get
                {
                    return ResourceManager.GetString("PositionalParamsWrongLength", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Prefix {0} does not map to a namespace.
            /// </summary>
            internal static string PrefixNotFound
            {
                get
                {
                    return ResourceManager.GetString("PrefixNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The prefix {0} could not be found.
            /// </summary>
            internal static string PrefixNotInFrames
            {
                get
                {
                    return ResourceManager.GetString("PrefixNotInFrames", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} property on {1} does not allow you to specify text.
            /// </summary>
            internal static string PropertyDoesNotTakeText
            {
                get
                {
                    return ResourceManager.GetString("PropertyDoesNotTakeText", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} is not implemented.
            /// </summary>
            internal static string PropertyNotImplemented
            {
                get
                {
                    return ResourceManager.GetString("PropertyNotImplemented", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Provide value on {0} threw an exception.
            /// </summary>
            internal static string ProvideValue
            {
                get
                {
                    return ResourceManager.GetString("ProvideValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot call MarkupExtension.ProvideValue because of a cyclical dependency. Properties inside a MarkupExtension cannot reference objects that reference the result of the MarkupExtension. The affected MarkupExtensions are:
            /// </summary>
            internal static string ProvideValueCycle
            {
                get
                {
                    return ResourceManager.GetString("ProvideValueCycle", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} type name does not have the expected format className, assembly.
            /// </summary>
            internal static string QualifiedNameHasWrongFormat
            {
                get
                {
                    return ResourceManager.GetString("QualifiedNameHasWrongFormat", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Quote characters  or &quot; are only allowed at the start of values.
            /// </summary>
            internal static string QuoteCharactersOutOfPlace
            {
                get
                {
                    return ResourceManager.GetString("QuoteCharactersOutOfPlace", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Value cannot be null. Object reference: {0}.
            /// </summary>
            internal static string ReferenceIsNull
            {
                get
                {
                    return ResourceManager.GetString("ReferenceIsNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for schemaContext parameter cannot be different from savedContext.SchemaContext
            /// </summary>
            internal static string SavedContextSchemaContextMismatch
            {
                get
                {
                    return ResourceManager.GetString("SavedContextSchemaContextMismatch", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for savedContext.SchemaContext cannot be null
            /// </summary>
            internal static string SavedContextSchemaContextNull
            {
                get
                {
                    return ResourceManager.GetString("SavedContextSchemaContextNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for SchemaContext on writer must be initialized before accessing the reader.
            /// </summary>
            internal static string SchemaContextNotInitialized
            {
                get
                {
                    return ResourceManager.GetString("SchemaContextNotInitialized", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for SchemaContext cannot be null.
            /// </summary>
            internal static string SchemaContextNull
            {
                get
                {
                    return ResourceManager.GetString("SchemaContextNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set SandboxExternalContent to true in partial trust.
            /// </summary>
            internal static string SecurityExceptionForSettingSandboxExternalToTrue
            {
                get
                {
                    return ResourceManager.GetString("SecurityExceptionForSettingSandboxExternalToTrue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Invalid security XML. Missing expected attribute {0}.
            /// </summary>
            internal static string SecurityXmlMissingAttribute
            {
                get
                {
                    return ResourceManager.GetString("SecurityXmlMissingAttribute", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Invalid security XML. Unexpected tag {0}, expected {1}.
            /// </summary>
            internal static string SecurityXmlUnexpectedTag
            {
                get
                {
                    return ResourceManager.GetString("SecurityXmlUnexpectedTag", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Invalid security XML. Unexpected value {0} in attribute {1}, expected {2}.
            /// </summary>
            internal static string SecurityXmlUnexpectedValue
            {
                get
                {
                    return ResourceManager.GetString("SecurityXmlUnexpectedValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for This serviceType is already registered to another service.
            /// </summary>
            internal static string ServiceTypeAlreadyAdded
            {
                get
                {
                    return ResourceManager.GetString("ServiceTypeAlreadyAdded", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Set connectionId threw an exception.
            /// </summary>
            internal static string SetConnectionId
            {
                get
                {
                    return ResourceManager.GetString("SetConnectionId", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0}.{1} is a property without a getter and is not a valid XAML property.
            /// </summary>
            internal static string SetOnlyProperty
            {
                get
                {
                    return ResourceManager.GetString("SetOnlyProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set TargetType on a non-attachable Member.
            /// </summary>
            internal static string SetTargetTypeOnNonAttachableMember
            {
                get
                {
                    return ResourceManager.GetString("SetTargetTypeOnNonAttachableMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Setting properties is not allowed on a type converted instance. Property = {0}
            /// </summary>
            internal static string SettingPropertiesIsNotAllowed
            {
                get
                {
                    return ResourceManager.GetString("SettingPropertiesIsNotAllowed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Setting xml:base on {0} threw an exception.
            /// </summary>
            internal static string SetUriBase
            {
                get
                {
                    return ResourceManager.GetString("SetUriBase", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Set property {0} threw an exception.
            /// </summary>
            internal static string SetValue
            {
                get
                {
                    return ResourceManager.GetString("SetValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Setting xml instance on {0} threw an exception.
            /// </summary>
            internal static string SetXmlInstance
            {
                get
                {
                    return ResourceManager.GetString("SetXmlInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Method {0} is not supported by default. It can be implemented in derived classes.
            /// </summary>
            internal static string ShouldOverrideMethod
            {
                get
                {
                    return ResourceManager.GetString("ShouldOverrideMethod", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for ShouldSerialize check failed for member {0}.
            /// </summary>
            internal static string ShouldSerializeFailed
            {
                get
                {
                    return ResourceManager.GetString("ShouldSerializeFailed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Directly Assignable Fixups must only have one name.
            /// </summary>
            internal static string SimpleFixupsMustHaveOneName
            {
                get
                {
                    return ResourceManager.GetString("SimpleFixupsMustHaveOneName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Parameter cannot be a zero-length string.
            /// </summary>
            internal static string StringEmpty
            {
                get
                {
                    return ResourceManager.GetString("StringEmpty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The string is null or empty.
            /// </summary>
            internal static string StringIsNullOrEmpty
            {
                get
                {
                    return ResourceManager.GetString("StringIsNullOrEmpty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Deferred load section was not collected in {0}.
            /// </summary>
            internal static string TemplateNotCollected
            {
                get
                {
                    return ResourceManager.GetString("TemplateNotCollected", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Thread is already started.
            /// </summary>
            internal static string ThreadAlreadyStarted
            {
                get
                {
                    return ResourceManager.GetString("ThreadAlreadyStarted", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Empty token encountered at position {0} while parsing {1}.
            /// </summary>
            internal static string TokenizerHelperEmptyToken
            {
                get
                {
                    return ResourceManager.GetString("TokenizerHelperEmptyToken", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Extra data encountered at position {0} while parsing {1}.
            /// </summary>
            internal static string TokenizerHelperExtraDataEncountered
            {
                get
                {
                    return ResourceManager.GetString("TokenizerHelperExtraDataEncountered", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Missing end quote encountered while parsing {0}.
            /// </summary>
            internal static string TokenizerHelperMissingEndQuote
            {
                get
                {
                    return ResourceManager.GetString("TokenizerHelperMissingEndQuote", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Premature string termination encountered while parsing {0}.
            /// </summary>
            internal static string TokenizerHelperPrematureStringTermination
            {
                get
                {
                    return ResourceManager.GetString("TokenizerHelperPrematureStringTermination", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Error with member {0}.{1}.  It has more than one {2}.
            /// </summary>
            internal static string TooManyAttributes
            {
                get
                {
                    return ResourceManager.GetString("TooManyAttributes", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Error with type {0}.  It has more than one {1}.
            /// </summary>
            internal static string TooManyAttributesOnType
            {
                get
                {
                    return ResourceManager.GetString("TooManyAttributesOnType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Only one TypeConverter attribute is allowed on a type.
            /// </summary>
            internal static string TooManyTypeConverterAttributes
            {
                get
                {
                    return ResourceManager.GetString("TooManyTypeConverterAttributes", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for (null)
            /// </summary>
            internal static string ToStringNull
            {
                get
                {
                    return ResourceManager.GetString("ToStringNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Object {0} assigned to directive {1} has properties which are references to named object(s) {2} which have not yet been defined. Forward references, or references to objects that contain forward references, are not supported inside object construction directives.
            /// </summary>
            internal static string TransitiveForwardRefDirectives
            {
                get
                {
                    return ResourceManager.GetString("TransitiveForwardRefDirectives", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed to create a {0} from the text {1}.
            /// </summary>
            internal static string TypeConverterFailed
            {
                get
                {
                    return ResourceManager.GetString("TypeConverterFailed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Failed to convert {0} to type {1}.
            /// </summary>
            internal static string TypeConverterFailed2
            {
                get
                {
                    return ResourceManager.GetString("TypeConverterFailed2", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The name of the type {0} contains characters that are invalid in XAML.
            /// </summary>
            internal static string TypeHasInvalidXamlName
            {
                get
                {
                    return ResourceManager.GetString("TypeHasInvalidXamlName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type {0} does not have a content property. Specify the name of the property to set, or add a ContentPropertyAttribute or TypeConverterAttribute on the type.
            /// </summary>
            internal static string TypeHasNoContentProperty
            {
                get
                {
                    return ResourceManager.GetString("TypeHasNoContentProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot change property metadata after it has been associated with a property.
            /// </summary>
            internal static string TypeMetadataCannotChangeAfterUse
            {
                get
                {
                    return ResourceManager.GetString("TypeMetadataCannotChangeAfterUse", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type name {0} cannot have a dot ..
            /// </summary>
            internal static string TypeNameCannotHavePeriod
            {
                get
                {
                    return ResourceManager.GetString("TypeNameCannotHavePeriod", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type reference cannot find type named {0}.
            /// </summary>
            internal static string TypeNotFound
            {
                get
                {
                    return ResourceManager.GetString("TypeNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Type {0} is not public.
            /// </summary>
            internal static string TypeNotPublic
            {
                get
                {
                    return ResourceManager.GetString("TypeNotPublic", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unclosed quoted value.
            /// </summary>
            internal static string UnclosedQuote
            {
                get
                {
                    return ResourceManager.GetString("UnclosedQuote", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected close of XAML Node Stream.
            /// </summary>
            internal static string UnexpectedClose
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedClose", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Invalid metadata for attribute {0} on {1}. Expected {2} argument(s) of type {3}.
            /// </summary>
            internal static string UnexpectedConstructorArg
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedConstructorArg", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected {0} in parse rule {1}.
            /// </summary>
            internal static string UnexpectedNodeType
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedNodeType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Parameter is unexpected type {0}. Expected type is {1}.
            /// </summary>
            internal static string UnexpectedParameterType
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedParameterType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected token {0} in rule: {1}, in {2}.
            /// </summary>
            internal static string UnexpectedToken
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedToken", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected token after end of markup extension.
            /// </summary>
            internal static string UnexpectedTokenAfterME
            {
                get
                {
                    return ResourceManager.GetString("UnexpectedTokenAfterME", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unhandled BoolTypeBit.
            /// </summary>
            internal static string UnhandledBoolTypeBit
            {
                get
                {
                    return ResourceManager.GetString("UnhandledBoolTypeBit", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for [{0}({1})]5D; on {2} is not a known property.
            /// </summary>
            internal static string UnknownAttributeProperty
            {
                get
                {
                    return ResourceManager.GetString("UnknownAttributeProperty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unknown member {0} on {1}.
            /// </summary>
            internal static string UnknownMember
            {
                get
                {
                    return ResourceManager.GetString("UnknownMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unknown member {0} on unknown type {1}.
            /// </summary>
            internal static string UnknownMemberOnUnknownType
            {
                get
                {
                    return ResourceManager.GetString("UnknownMemberOnUnknownType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unknown member {0}.
            /// </summary>
            internal static string UnknownMemberSimple
            {
                get
                {
                    return ResourceManager.GetString("UnknownMemberSimple", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unknown type {0}.
            /// </summary>
            internal static string UnknownType
            {
                get
                {
                    return ResourceManager.GetString("UnknownType", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unresolved reference {0}.
            /// </summary>
            internal static string UnresolvedForwardReferences
            {
                get
                {
                    return ResourceManager.GetString("UnresolvedForwardReferences", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML namespace {0} is not resolved.
            /// </summary>
            internal static string UnresolvedNamespace
            {
                get
                {
                    return ResourceManager.GetString("UnresolvedNamespace", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Uri {0} was not found.
            /// </summary>
            internal static string UriNotFound
            {
                get
                {
                    return ResourceManager.GetString("UriNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Error with type {0}. MarkupExtensions cannot use the UsableDuringInitialization attribute.
            /// </summary>
            internal static string UsableDuringInitializationOnME
            {
                get
                {
                    return ResourceManager.GetString("UsableDuringInitializationOnME", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for A value in the {0} array is null.
            /// </summary>
            internal static string ValueInArrayIsNull
            {
                get
                {
                    return ResourceManager.GetString("ValueInArrayIsNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XAML Node Stream: Value nodes must be followed by EndMember.
            /// </summary>
            internal static string ValueMustBeFollowedByEndMember
            {
                get
                {
                    return ResourceManager.GetString("ValueMustBeFollowedByEndMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Specified index is out of range or child at index is null. Do not call this method if VisualChildrenCount returns zero, indicating that the Visual has no children.
            /// </summary>
            internal static string Visual_ArgumentOutOfRange
            {
                get
                {
                    return ResourceManager.GetString("Visual_ArgumentOutOfRange", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for White space is not allowed after end of markup extension.
            /// </summary>
            internal static string WhitespaceAfterME
            {
                get
                {
                    return ResourceManager.GetString("WhitespaceAfterME", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for XamlXmlWriter cannot write value {0} which contains significant white space in collection {1}.
            /// </summary>
            internal static string WhiteSpaceInCollection
            {
                get
                {
                    return ResourceManager.GetString("WhiteSpaceInCollection", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for An attempt was made to write to a XamlWriter that has had its Closed method called.
            /// </summary>
            internal static string WriterIsClosed
            {
                get
                {
                    return ResourceManager.GetString("WriterIsClosed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unexpected XAML node type {0} from XamlReader in XamlFactory.
            /// </summary>
            internal static string XamlFactoryInvalidXamlNode
            {
                get
                {
                    return ResourceManager.GetString("XamlFactoryInvalidXamlNode", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot set SchemaContext on XamlMarkupExtensionWriter.
            /// </summary>
            internal static string XamlMarkupExtensionWriterCannotSetSchemaContext
            {
                get
                {
                    return ResourceManager.GetString("XamlMarkupExtensionWriterCannotSetSchemaContext", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write a value that is not a string.
            /// </summary>
            internal static string XamlMarkupExtensionWriterCannotWriteNonstringValue
            {
                get
                {
                    return ResourceManager.GetString("XamlMarkupExtensionWriterCannotWriteNonstringValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The member {0} has already been written.
            /// </summary>
            internal static string XamlMarkupExtensionWriterDuplicateMember
            {
                get
                {
                    return ResourceManager.GetString("XamlMarkupExtensionWriterDuplicateMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Errors detected in input.
            /// </summary>
            internal static string XamlMarkupExtensionWriterInputInvalid
            {
                get
                {
                    return ResourceManager.GetString("XamlMarkupExtensionWriterInputInvalid", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot convert this XamlTypeName instance to a string because the provided INamespacePrefixLookup could not generate a prefix for the namespace {0}.
            /// </summary>
            internal static string XamlTypeNameCannotGetPrefix
            {
                get
                {
                    return ResourceManager.GetString("XamlTypeNameCannotGetPrefix", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot convert this XamlTypeName instance to a string because the Name property is null or empty. Set the Name property before calling XamlTypeName.ToString.
            /// </summary>
            internal static string XamlTypeNameNameIsNullOrEmpty
            {
                get
                {
                    return ResourceManager.GetString("XamlTypeNameNameIsNullOrEmpty", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot convert this XamlTypeName instance to a string because the Namespace property is null. Set the Namespace property before calling XamlTypeName.ToString.
            /// </summary>
            internal static string XamlTypeNameNamespaceIsNull
            {
                get
                {
                    return ResourceManager.GetString("XamlTypeNameNamespaceIsNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot write a value that is not a string.
            /// </summary>
            internal static string XamlXmlWriterCannotWriteNonstringValue
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterCannotWriteNonstringValue", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The member {0} has already been written.
            /// </summary>
            internal static string XamlXmlWriterDuplicateMember
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterDuplicateMember", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The argument isObjectFromMember can only be set to true when the type is a collection.
            /// </summary>
            internal static string XamlXmlWriterIsObjectFromMemberSetForArraysOrNonCollections
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterIsObjectFromMemberSetForArraysOrNonCollections", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Namespace {0} already has a prefix defined in current scope.
            /// </summary>
            internal static string XamlXmlWriterNamespaceAlreadyHasPrefixInCurrentScope
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterNamespaceAlreadyHasPrefixInCurrentScope", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The prefix {0} is already defined in current scope.
            /// </summary>
            internal static string XamlXmlWriterPrefixAlreadyDefinedInCurrentScope
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterPrefixAlreadyDefinedInCurrentScope", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to call {0} in current state.
            /// </summary>
            internal static string XamlXmlWriterWriteNotSupportedInCurrentState
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterWriteNotSupportedInCurrentState", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unable to call WriteObject with isObjectFromMember set to true in current state.
            /// </summary>
            internal static string XamlXmlWriterWriteObjectNotSupportedInCurrentState
            {
                get
                {
                    return ResourceManager.GetString("XamlXmlWriterWriteObjectNotSupportedInCurrentState", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Need to implement public/internal sorting.
            /// </summary>
            internal static string XaslTypePropertiesNotImplemented
            {
                get
                {
                    return ResourceManager.GetString("XaslTypePropertiesNotImplemented", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Specified class name {0} doesnt match actual root instance type {1}. Remove the Class directive or provide an instance via XamlObjectWriterSettings.RootObjectInstance.
            /// </summary>
            internal static string XClassMustMatchRootInstance
            {
                get
                {
                    return ResourceManager.GetString("XClassMustMatchRootInstance", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Choice cannot follow a Fallback.
            /// </summary>
            internal static string XCRChoiceAfterFallback
            {
                get
                {
                    return ResourceManager.GetString("XCRChoiceAfterFallback", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for AlternateContent must contain one or more Choice elements.
            /// </summary>
            internal static string XCRChoiceNotFound
            {
                get
                {
                    return ResourceManager.GetString("XCRChoiceNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Choice is valid only in AlternateContent.
            /// </summary>
            internal static string XCRChoiceOnlyInAC
            {
                get
                {
                    return ResourceManager.GetString("XCRChoiceOnlyInAC", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for There is a cycle of XML compatibility definitions, such that namespace {0} overrides itself. This could be due to inconsistent XmlnsCompatibilityAttributes in different assemblies. Please change the definitions to eliminate this cycle, or pass a non-conflicting set of Reference Assemblies in the XamlSchemaContext constructor.
            /// </summary>
            internal static string XCRCompatCycle
            {
                get
                {
                    return ResourceManager.GetString("XCRCompatCycle", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Duplicate Preserve declaration for element {1} in namespace {0}.
            /// </summary>
            internal static string XCRDuplicatePreserve
            {
                get
                {
                    return ResourceManager.GetString("XCRDuplicatePreserve", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Duplicate ProcessContent declaration for element {1} in namespace {0}.
            /// </summary>
            internal static string XCRDuplicateProcessContent
            {
                get
                {
                    return ResourceManager.GetString("XCRDuplicateProcessContent", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Duplicate wildcard Preserve declaration for namespace {0}.
            /// </summary>
            internal static string XCRDuplicateWildcardPreserve
            {
                get
                {
                    return ResourceManager.GetString("XCRDuplicateWildcardPreserve", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Duplicate wildcard ProcessContent declaration for namespace {0}.
            /// </summary>
            internal static string XCRDuplicateWildcardProcessContent
            {
                get
                {
                    return ResourceManager.GetString("XCRDuplicateWildcardProcessContent", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Fallback is valid only in AlternateContent.
            /// </summary>
            internal static string XCRFallbackOnlyInAC
            {
                get
                {
                    return ResourceManager.GetString("XCRFallbackOnlyInAC", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} element is not a valid child of AlternateContent. Only Choice and Fallback elements are valid children of an AlternateContent element.
            /// </summary>
            internal static string XCRInvalidACChild
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidACChild", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} attribute is not valid for {1} element.
            /// </summary>
            internal static string XCRInvalidAttribInElement
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidAttribInElement", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} format is not valid.
            /// </summary>
            internal static string XCRInvalidFormat
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidFormat", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot have both a specific and a wildcard Preserve declaration for namespace {0}.
            /// </summary>
            internal static string XCRInvalidPreserve
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidPreserve", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Cannot have both a specific and a wildcard ProcessContent declaration for namespace {0}.
            /// </summary>
            internal static string XCRInvalidProcessContent
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidProcessContent", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Requires attribute must contain a valid namespace prefix.
            /// </summary>
            internal static string XCRInvalidRequiresAttribute
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidRequiresAttribute", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} attribute value is not a valid XML name.
            /// </summary>
            internal static string XCRInvalidXMLName
            {
                get
                {
                    return ResourceManager.GetString("XCRInvalidXMLName", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for AlternateContent must contain only one Fallback element.
            /// </summary>
            internal static string XCRMultipleFallbackFound
            {
                get
                {
                    return ResourceManager.GetString("XCRMultipleFallbackFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for MustUnderstand condition failed on namespace {0}.
            /// </summary>
            internal static string XCRMustUnderstandFailed
            {
                get
                {
                    return ResourceManager.GetString("XCRMustUnderstandFailed", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} namespace cannot preserve items; it must be declared Ignorable first.
            /// </summary>
            internal static string XCRNSPreserveNotIgnorable
            {
                get
                {
                    return ResourceManager.GetString("XCRNSPreserveNotIgnorable", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} namespace cannot process content; it must be declared Ignorable first.
            /// </summary>
            internal static string XCRNSProcessContentNotIgnorable
            {
                get
                {
                    return ResourceManager.GetString("XCRNSProcessContentNotIgnorable", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Choice must contain a Requires attribute.
            /// </summary>
            internal static string XCRRequiresAttribNotFound
            {
                get
                {
                    return ResourceManager.GetString("XCRRequiresAttribNotFound", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for {0} prefix is not defined.
            /// </summary>
            internal static string XCRUndefinedPrefix
            {
                get
                {
                    return ResourceManager.GetString("XCRUndefinedPrefix", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unrecognized compatibility attribute {0}.
            /// </summary>
            internal static string XCRUnknownCompatAttrib
            {
                get
                {
                    return ResourceManager.GetString("XCRUnknownCompatAttrib", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for Unrecognized Compatibility element {0}.
            /// </summary>
            internal static string XCRUnknownCompatElement
            {
                get
                {
                    return ResourceManager.GetString("XCRUnknownCompatElement", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The value for XmlData property {0} is null or not IXmlSerializable.
            /// </summary>
            internal static string XmlDataNull
            {
                get
                {
                    return ResourceManager.GetString("XmlDataNull", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for There is a cycle of XmlnsCompatibleWithAttribute definitions in assembly {0}, such that namespace {1} overrides itself. Change the definitions to eliminate this cycle.
            /// </summary>
            internal static string XmlnsCompatCycle
            {
                get
                {
                    return ResourceManager.GetString("XmlnsCompatCycle", resourceCulture);
                }
            }

            /// <summary>
            ///   The localized string for The value for XmlData property {0} is not an XmlReader.
            /// </summary>
            internal static string XmlValueNotReader
            {
                get
                {
                    return ResourceManager.GetString("XmlValueNotReader", resourceCulture);
                }
            }
    }

public class ReferenceEqualityComparer:IEqualityComparer<object>
{
    public static ReferenceEqualityComparer Instance{ get; }
    public bool Equals(object x, object y)
    {
        throw new NotImplementedException();
    }

    public int GetHashCode(object obj)
    {
        throw new NotImplementedException();
    }
}
