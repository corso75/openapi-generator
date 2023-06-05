/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.0.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */



#include "Format_test.h"

#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <stdexcept>
#include <regex>
#include <boost/lexical_cast.hpp>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include "helpers.h"

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

Format_test::Format_test(boost::property_tree::ptree const& pt)
{
        fromPropertyTree(pt);
}


std::string Format_test::toJsonString(bool prettyJson /* = false */) const
{
	std::stringstream ss;
	write_json(ss, this->toPropertyTree(), prettyJson);
    // workaround inspired by: https://stackoverflow.com/a/56395440
    std::regex reg("\\\"([0-9]+\\.{0,1}[0-9]*)\\\"");
    std::string result = std::regex_replace(ss.str(), reg, "$1");
    return result;
}

void Format_test::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	this->fromPropertyTree(pt);
}

ptree Format_test::toPropertyTree() const
{
	ptree pt;
	ptree tmp_node;
	pt.put("integer", m_integer);
	pt.put("int32", m_Int32);
	pt.put("int64", m_Int64);
	pt.put("number", m_number);
	pt.put("float", m_float);
	pt.put("double", m_double);
	pt.put("string", m_string);
	pt.put("date", m_date);
	pt.put("dateTime", m_DateTime);
	pt.put("uuid", m_Uuid);
	pt.put("password", m_Password);
	pt.put("pattern_with_digits", m_Pattern_with_digits);
	pt.put("pattern_with_digits_and_delimiter", m_Pattern_with_digits_and_delimiter);
	return pt;
}

void Format_test::fromPropertyTree(ptree const &pt)
{
	ptree tmp_node;
	m_integer = pt.get("integer", 0);
	m_Int32 = pt.get("int32", 0);
	m_Int64 = pt.get("int64", 0L);
	m_number = pt.get("number", 0.0);
	m_float = pt.get("float", 0.0f);
	m_double = pt.get("double", 0.0);
	m_string = pt.get("string", "");
	m_date = pt.get("date", "");
	m_DateTime = pt.get("dateTime", "");
	m_Uuid = pt.get("uuid", "");
	m_Password = pt.get("password", "");
	m_Pattern_with_digits = pt.get("pattern_with_digits", "");
	m_Pattern_with_digits_and_delimiter = pt.get("pattern_with_digits_and_delimiter", "");
}

int32_t Format_test::getInteger() const
{
    return m_integer;
}

void Format_test::setInteger(int32_t value)
{
    m_integer = value;
}


int32_t Format_test::getInt32() const
{
    return m_Int32;
}

void Format_test::setInt32(int32_t value)
{
    m_Int32 = value;
}


int64_t Format_test::getInt64() const
{
    return m_Int64;
}

void Format_test::setInt64(int64_t value)
{
    m_Int64 = value;
}


double Format_test::getNumber() const
{
    return m_number;
}

void Format_test::setNumber(double value)
{
    m_number = value;
}


float Format_test::getFloat() const
{
    return m_float;
}

void Format_test::setFloat(float value)
{
    m_float = value;
}


double Format_test::getDouble() const
{
    return m_double;
}

void Format_test::setDouble(double value)
{
    m_double = value;
}


std::string Format_test::getDecimal() const
{
    return m_decimal;
}

void Format_test::setDecimal(std::string value)
{
    m_decimal = value;
}


std::string Format_test::getString() const
{
    return m_string;
}

void Format_test::setString(std::string value)
{
    m_string = value;
}


std::string Format_test::getByte() const
{
    return m_Byte;
}

void Format_test::setByte(std::string value)
{
    m_Byte = value;
}


std::string Format_test::getBinary() const
{
    return m_binary;
}

void Format_test::setBinary(std::string value)
{
    m_binary = value;
}


std::string Format_test::getDate() const
{
    return m_date;
}

void Format_test::setDate(std::string value)
{
    m_date = value;
}


std::string Format_test::getDateTime() const
{
    return m_DateTime;
}

void Format_test::setDateTime(std::string value)
{
    m_DateTime = value;
}


std::string Format_test::getUuid() const
{
    return m_Uuid;
}

void Format_test::setUuid(std::string value)
{
    m_Uuid = value;
}


std::string Format_test::getPassword() const
{
    return m_Password;
}

void Format_test::setPassword(std::string value)
{
    m_Password = value;
}


std::string Format_test::getPatternWithDigits() const
{
    return m_Pattern_with_digits;
}

void Format_test::setPatternWithDigits(std::string value)
{
    m_Pattern_with_digits = value;
}


std::string Format_test::getPatternWithDigitsAndDelimiter() const
{
    return m_Pattern_with_digits_and_delimiter;
}

void Format_test::setPatternWithDigitsAndDelimiter(std::string value)
{
    m_Pattern_with_digits_and_delimiter = value;
}



std::vector<Format_test> createFormat_testVectorFromJsonString(const std::string& json)
{
    std::stringstream sstream(json);
    boost::property_tree::ptree pt;
    boost::property_tree::json_parser::read_json(sstream,pt);

    auto vec = std::vector<Format_test>();
    for (const auto& child: pt) {
        vec.emplace_back(Format_test(child.second));
    }

    return vec;
}

}
}
}
}

