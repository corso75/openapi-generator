/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package petstoreserver




// SpecialInfo - An order info for a pets from the pet store
type SpecialInfo struct {

	Promotion bool `json:"promotion,omitempty"`

	RequireTest string `json:"requireTest"`

	Type string `json:"type,omitempty"`
}

// AssertSpecialInfoRequired checks if the required fields are not zero-ed
func AssertSpecialInfoRequired(obj SpecialInfo) error {
	elements := map[string]interface{}{
		"requireTest": obj.RequireTest,
	}
	for name, el := range elements {
		if isZero := IsZeroValue(el); isZero {
			return &RequiredError{Field: name}
		}
	}

	return nil
}

// AssertSpecialInfoConstraints checks if the values respects the defined constraints
func AssertSpecialInfoConstraints(obj SpecialInfo) error {
	return nil
}
