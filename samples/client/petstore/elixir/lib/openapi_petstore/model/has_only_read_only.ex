# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule OpenapiPetstore.Model.HasOnlyReadOnly do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :bar,
    :foo
  ]

  @type t :: %__MODULE__{
    :bar => String.t | nil,
    :foo => String.t | nil
  }
end

defimpl Poison.Decoder, for: OpenapiPetstore.Model.HasOnlyReadOnly do
  def decode(value, _options) do
    value
  end
end

